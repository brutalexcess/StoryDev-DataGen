namespace sddg
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFile = new System.Windows.Forms.ComboBox();
            this.btnDataStructure = new System.Windows.Forms.Button();
            this.cmbStructure = new System.Windows.Forms.ComboBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateRecord);
            this.panel1.Controls.Add(this.btnNewRecord);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbFile);
            this.panel1.Controls.Add(this.btnDataStructure);
            this.panel1.Controls.Add(this.cmbStructure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 73);
            this.panel1.TabIndex = 5;
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Enabled = false;
            this.btnNewRecord.Location = new System.Drawing.Point(556, 12);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(104, 23);
            this.btnNewRecord.TabIndex = 10;
            this.btnNewRecord.Text = "New Record";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(59, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(224, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Search:";
            // 
            // cmbFile
            // 
            this.cmbFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFile.FormattingEnabled = true;
            this.cmbFile.Location = new System.Drawing.Point(289, 14);
            this.cmbFile.Name = "cmbFile";
            this.cmbFile.Size = new System.Drawing.Size(147, 21);
            this.cmbFile.TabIndex = 7;
            this.cmbFile.SelectedIndexChanged += new System.EventHandler(this.cmbFile_SelectedIndexChanged);
            // 
            // btnDataStructure
            // 
            this.btnDataStructure.Location = new System.Drawing.Point(12, 12);
            this.btnDataStructure.Name = "btnDataStructure";
            this.btnDataStructure.Size = new System.Drawing.Size(123, 23);
            this.btnDataStructure.TabIndex = 6;
            this.btnDataStructure.Text = "Create Data Structure";
            this.btnDataStructure.UseVisualStyleBackColor = true;
            this.btnDataStructure.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbStructure
            // 
            this.cmbStructure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStructure.FormattingEnabled = true;
            this.cmbStructure.Location = new System.Drawing.Point(141, 14);
            this.cmbStructure.Name = "cmbStructure";
            this.cmbStructure.Size = new System.Drawing.Size(142, 21);
            this.cmbStructure.TabIndex = 5;
            this.cmbStructure.SelectedIndexChanged += new System.EventHandler(this.cmbStructure_SelectedIndexChanged);
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.lbResults);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 73);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(672, 288);
            this.pnlContent.TabIndex = 6;
            // 
            // lbResults
            // 
            this.lbResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(0, 0);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(672, 288);
            this.lbResults.TabIndex = 0;
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.Enabled = false;
            this.btnUpdateRecord.Location = new System.Drawing.Point(556, 39);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(104, 23);
            this.btnUpdateRecord.TabIndex = 11;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = true;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 361);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFile;
        private System.Windows.Forms.Button btnDataStructure;
        private System.Windows.Forms.ComboBox cmbStructure;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btnUpdateRecord;
    }
}