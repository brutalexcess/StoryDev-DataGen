namespace sddg
{
    partial class CtlCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.cw = new sddg.CodeWindow();
            ((System.ComponentModel.ISupportInitialize)(this.cw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(107, 175);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Code:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cw
            // 
            this.cw.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.cw.AutoScrollMinSize = new System.Drawing.Size(0, 15);
            this.cw.BackBrush = null;
            this.cw.CharHeight = 15;
            this.cw.CharWidth = 8;
            this.cw.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cw.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.cw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cw.Font = new System.Drawing.Font("Courier New", 10F);
            this.cw.IsReplaceMode = false;
            this.cw.Location = new System.Drawing.Point(107, 0);
            this.cw.Name = "cw";
            this.cw.Paddings = new System.Windows.Forms.Padding(0);
            this.cw.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.cw.Size = new System.Drawing.Size(398, 175);
            this.cw.TabIndex = 2;
            this.cw.Text = "codeWindow1";
            this.cw.WordWrap = true;
            this.cw.Zoom = 100;
            // 
            // CtlCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cw);
            this.Controls.Add(this.lblName);
            this.Name = "CtlCode";
            this.Size = new System.Drawing.Size(505, 175);
            ((System.ComponentModel.ISupportInitialize)(this.cw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private CodeWindow cw;
    }
}
