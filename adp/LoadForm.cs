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
        string File;
        bool updating;

        public LoadForm(Type Class, string file = "")
        {
            InitializeComponent();

            File = file;

            TypeClass = Class;

            var tempControls = new List<Control>();
            var fields = Class.GetFields();
            
            foreach (FieldInfo f in fields)
            {
                var attr = f.GetCustomAttribute(typeof(ControlType));
                if (attr != null)
                {
                    var obj = (ControlType)attr;
                    if (file.Contains(' ') && obj.Identifier)
                        updating = true;
                    

                    if (obj.controlType == "string")
                        tempControls.Add(new CtlString(f.Name));
                    else if (obj.controlType == "lstring")
                        tempControls.Add(new CtlLString(f.Name));
                    else if (obj.controlType == "code")
                        tempControls.Add(new CtlCode(f.Name));
                }
            }

            pnlFormContent.Controls.AddRange(tempControls.Reverse<Control>().ToArray());
        }
    }
}
