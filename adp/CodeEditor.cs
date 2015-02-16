using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sddg
{
    public partial class CodeEditor : Form
    {
        private CodeWindow cw;

        public string CodeText { get { return cw.Text; } set { cw.Text = value; } }

        public CodeEditor()
        {
            InitializeComponent();

            cw = new CodeWindow();

            Controls.Add(cw);
        }

        public delegate void CodeSubmit();
        public event CodeSubmit OnCodeSubmit;

        private void CodeEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OnCodeSubmit != null)
                OnCodeSubmit();
        }

    }

    
    
}
