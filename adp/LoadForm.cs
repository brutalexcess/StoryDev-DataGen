using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace sddg
{
    public partial class LoadForm : Form
    {
        Type TypeClass;
        Type TypeData;
        bool updating;
        FieldInfo[] fields;
        dynamic dataList;
        dynamic dataContent;

        //If List itself - get the dataList and create a new Record
        //If a reference in the list - get the reference and store in dataContent, use index as reference
        public LoadForm(Type Class, dynamic dataList, int index = -1)
        {
            InitializeComponent();

            this.dataList = dataList;
            TypeData = dataList.GetType();
            TypeClass = Class;

            var tempControls = new List<Control>();
            fields = Class.GetFields();

            //updating - true means reference, dataContent is the reference to the list item
            if (index > -1 && TypeData == typeof(List<>))
            {
                updating = true;
                btnUpdateOrCreate.Text = "Update";
                dataContent = TypeData.GetProperty("Data").GetValue(dataList, new object[] { index });
            }

            foreach (FieldInfo f in fields)
            {
                var attr = f.GetCustomAttribute(typeof(JsonControlType));
                if (attr != null)
                {
                    var obj = (JsonControlType)attr;

                    if (obj.controlType == "string")
                        tempControls.Add(new CtlString(obj.FieldTitle != "" ? obj.FieldTitle : f.Name));
                    else if (obj.controlType == "lstring")
                        tempControls.Add(new CtlLString(obj.FieldTitle != "" ? obj.FieldTitle : f.Name));
                    else if (obj.controlType == "code")
                        tempControls.Add(new CtlCode(obj.FieldTitle != "" ? obj.FieldTitle : f.Name));
                }
                var attrCategory = (JsonCategory)f.GetCustomAttribute(typeof(JsonCategory));
                if (attrCategory != null)
                {

                }
            }

            pnlFormContent.Controls.AddRange(tempControls.Reverse<Control>().ToArray());
        }

        private void btnUpdateOrCreate_Click(object sender, EventArgs e)
        {
            if (!updating)
            {
                var obj = Activator.CreateInstance(TypeClass);
                var t = obj.GetType();
                foreach (Control ctl in pnlFormContent.Controls)
                {
                    foreach (FieldInfo f in fields)
                    {
                        var attr = (JsonControlType)f.GetCustomAttribute(typeof(JsonControlType));
                        var property = ctl.GetType().GetProperty("FieldName");
                        var fieldName = property.GetValue(ctl);
                        if (f.Name == (string)fieldName || attr.FieldTitle == (string)fieldName)
                        {
                            t.GetField(f.Name).SetValue(obj, ctl.GetType().GetProperty("FieldValue").GetValue(ctl));
                            break;
                        }
                    }
                }
                TypeData.GetMethod("Add").Invoke(dataList, new object[] { obj });
            }
            else
            {
                var obj = dataContent.GetType();
                foreach (Control ctl in pnlFormContent.Controls)
                {
                    foreach(FieldInfo f in fields)
                    {
                        var attr = (JsonControlType)f.GetCustomAttribute(typeof(JsonControlType));
                        var property = ctl.GetType().GetProperty("FieldName");
                        var fieldName = property.GetValue(ctl);
                        if (f.Name == (string)fieldName || attr.FieldTitle == (string)fieldName)
                        {
                            obj.GetField(f.Name).SetValue(obj, ctl.GetType().GetProperty("FieldValue").GetValue(ctl));
                            break;
                        }
                    }
                }
                dataContent = obj;
            }
        }
    }
}
