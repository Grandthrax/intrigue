namespace Intrigue
{
    partial class LoanRequest
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
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.radioGroup2 = new DevExpress.XtraEditors.RadioGroup();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(13, 13);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Assasinate Rival"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Insult Rival"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Repay Double In 14 Turns"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Repay Triple in 14 Turns"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Offer Nothing")});
            this.radioGroup1.Size = new System.Drawing.Size(260, 133);
            this.radioGroup1.TabIndex = 0;
            // 
            // radioGroup2
            // 
            this.radioGroup2.Location = new System.Drawing.Point(279, 13);
            this.radioGroup2.Name = "radioGroup2";
            this.radioGroup2.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "10,000"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "20,000"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "100,000"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "500,000"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "1 Million")});
            this.radioGroup2.Size = new System.Drawing.Size(222, 133);
            this.radioGroup2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make Request";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LoanRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioGroup2);
            this.Controls.Add(this.radioGroup1);
            this.Name = "LoanRequest";
            this.Text = "LoanRequest";
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.RadioGroup radioGroup2;
        private System.Windows.Forms.Button button1;

    }
}