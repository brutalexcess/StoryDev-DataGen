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
    public partial class AddLocation : Form
    {
        public dynamic dataList;
        public Type type;

        public AddLocation()
        {
            InitializeComponent();

            sfdJson.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var obj = Activator.CreateInstance(typeof(DataList<>).MakeGenericType(type), txtLocation.Text);
            Type t = dataList.GetType();
            t.GetMethod("Add").Invoke(dataList, new object[] {obj});

            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            sfdJson.ShowDialog();
            txtLocation.Text = sfdJson.FileName;
        }

        private void AddLocation_Load(object sender, EventArgs e)
        {
            lblType.Text = dataList.GetType().ToString();
        }
    }
}
