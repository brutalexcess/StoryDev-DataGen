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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();

            PopulateStructureList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ds = new DataStructure();
            ds.StructureUpdating += ds_StructureUpdating;
            ds.ShowDialog();
        }

        void ds_StructureUpdating()
        {
            PopulateStructureList();
        }

        private void PopulateStructureList()
        {
            cmbStructure.Items.Clear();
            foreach (StructureType k in Structure.Structures)
            {
                cmbStructure.Items.Add(k.ClassName);
            }
        }

        private void PopulateFileList(dynamic list)
        {
            cmbFile.Items.Clear();
            foreach (dynamic listItem in list)
            {
                cmbFile.Items.Add(listItem.Location);
            }
            cmbFile.Items.Add("<Add Location...>");
        }


        private void SearchForm_Load(object sender, EventArgs e)
        {
            
        }

        private void cmbStructure_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStructure.SelectedIndex > -1)
            {
                foreach (StructureType st in Structure.Structures)
                {
                    if (st.ClassName == (string)cmbStructure.SelectedItem)
                    {
                        PopulateFileList(st.ClassDataList);
                    }
                }
            }
        }

        private void cmbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)cmbFile.SelectedItem == "<Add Location...>")
            {
                var addLocation = new AddLocation();
                addLocation.FormClosed += addLocation_FormClosed;
                foreach (StructureType st in Structure.Structures)
                {
                    if (st.ClassName == (string)cmbStructure.SelectedItem)
                    {
                        addLocation.dataList = st.ClassDataList;
                        addLocation.type = st.ClassType;
                        addLocation.ShowDialog();
                        break;
                    }
                }
                
            }
        }

        void addLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (StructureType st in Structure.Structures)
            {
                if (st.ClassName == (string)cmbStructure.SelectedItem)
                {
                    PopulateFileList(st.ClassDataList);
                }
            }
        }
    }
}
