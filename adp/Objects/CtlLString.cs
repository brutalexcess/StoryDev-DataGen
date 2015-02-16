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
    public partial class CtlLString : UserControl
    {
        public string FieldName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        public string FieldValue
        {
            get { return txtValue.Text; }
            set { txtValue.Text = value; }
        }

        public CtlLString(string fieldName)
        {
            InitializeComponent();

            FieldName = fieldName;
            Dock = DockStyle.Top;
        }

        private void txtValue_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                txtValue.SelectAll();

        }
    }
}
