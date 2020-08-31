namespace DATABASEPHASE2
{
    partial class Form5
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
            this.button1 = new System.Windows.Forms.Button();
            this.cr_denotestype = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_denotestype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERATE REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cr_denotestype
            // 
            this.cr_denotestype.ActiveViewIndex = -1;
            this.cr_denotestype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cr_denotestype.Cursor = System.Windows.Forms.Cursors.Default;
            this.cr_denotestype.Location = new System.Drawing.Point(12, 126);
            this.cr_denotestype.Name = "cr_denotestype";
            this.cr_denotestype.Size = new System.Drawing.Size(935, 447);
            this.cr_denotestype.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "DENOTES TYPE";
            // 
            // cmb_denotestype
            // 
            this.cmb_denotestype.FormattingEnabled = true;
            this.cmb_denotestype.Location = new System.Drawing.Point(362, 12);
            this.cmb_denotestype.Name = "cmb_denotestype";
            this.cmb_denotestype.Size = new System.Drawing.Size(160, 24);
            this.cmb_denotestype.TabIndex = 3;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 585);
            this.Controls.Add(this.cmb_denotestype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cr_denotestype);
            this.Controls.Add(this.button1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer cr_denotestype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_denotestype;
    }
}