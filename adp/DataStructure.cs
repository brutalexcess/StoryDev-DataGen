using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using FastColoredTextBoxNS;

namespace sddg
{
    public partial class DataStructure : Form
    {
        public DataStructure()
        {
            InitializeComponent();

            cw.UsingLanguage = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Structure.Add(cw.Text)) 
                Close();
        }

        public event StructureUpdating StructureUpdating;

        private void DataStructure_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (StructureUpdating != null)
                StructureUpdating();
        }
    }

    public delegate void StructureUpdating();
}
