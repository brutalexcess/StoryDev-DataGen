using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sddg
{
    public partial class CtlCode : UserControl
    {
        public string FieldName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string FieldValue
        {
            get { return cw.Text; }
            set { cw.Text = value; }
        }

        public CtlCode(string fieldName)
        {
            InitializeComponent();

            FieldName = fieldName;
            Dock = DockStyle.Top;
        }
    }
}
