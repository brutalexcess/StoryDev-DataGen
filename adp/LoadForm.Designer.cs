namespace sddg
{
    partial class LoadForm
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
            this.lblFile = new System.Windows.Forms.Label();
            this.btnUpdateOrCreate = new System.Windows.Forms.Button();
            this.pnlFormContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFile);
            this.panel1.Controls.Add(this.btnUpdateOrCreate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 35);
            this.panel1.TabIndex = 0;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(12, 11);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(52, 13);
            this.lblFile.TabIndex = 1;
            this.lblFile.Text = "Main File:";
            // 
            // btnUpdateOrCreate
            // 
            this.btnUpdateOrCreate.Location = new System.Drawing.Point(661, 6);
            this.btnUpdateOrCreate.Name = "btnUpdateOrCreate";
            this.btnUpdateOrCreate.Size = new System.Drawing.Size(88, 23);
            this.btnUpdateOrCreate.TabIndex = 0;
            this.btnUpdateOrCreate.Text = "Create";
            this.btnUpdateOrCreate.UseVisualStyleBackColor = true;
            this.btnUpdateOrCreate.Click += new System.EventHandler(this.btnUpdateOrCreate_Click);
            // 
            // pnlFormContent
            // 
            this.pnlFormContent.AutoScroll = true;
            this.pnlFormContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormContent.Location = new System.Drawing.Point(0, 35);
            this.pnlFormContent.Name = "pnlFormContent";
            this.pnlFormContent.Size = new System.Drawing.Size(761, 430);
            this.pnlFormContent.TabIndex = 1;
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 465);
            this.Controls.Add(this.pnlFormContent);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlFormContent;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Button btnUpdateOrCreate;
    }
}