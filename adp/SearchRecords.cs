using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace sddg
{
    public class SearchRecords
    {

        public static void CreateRecords(DataGridView gridView, dynamic list, FieldInfo[] searchableFields, string searchTerms = "")
        {
            gridView.Columns.Clear();
            foreach (FieldInfo f in searchableFields)
            {
                if (f.GetType() == typeof(string) || f.GetType() == typeof(int) || f.GetType() == typeof(float) ||
                    f.GetType() == typeof(double) || f.GetType() == typeof(Single))
                    gridView.Columns.Add(new DataGridViewTextBoxColumn());
                else if (f.GetType() == typeof(bool))
                    gridView.Columns.Add(new DataGridViewCheckBoxColumn());
                else
                    continue;
            }

            

            //Populate the rows
            foreach (dynamic item in list)
            {
                Type t = item.GetType();
                List<object> values = new List<object>();
                foreach (FieldInfo f in searchableFields)
                {
                    values.Add(t.GetField(f.Name).GetValue(item));
                        if (f.GetType() == typeof(string))
                        {
                            if (((string)t.GetField(f.Name).GetValue(item)).Contains(searchTerms))
                            {
                                
                            }
                        }
                    
                }
            }
        }

    }

}
