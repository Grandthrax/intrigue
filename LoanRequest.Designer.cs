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
            this.promiseRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.moneyRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.promiseRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyRadioGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // promiseRadioGroup
            // 
            this.promiseRadioGroup.Location = new System.Drawing.Point(13, 13);
            this.promiseRadioGroup.Name = "promiseRadioGroup";
            this.promiseRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Assasinate Rival"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Insult Rival"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(0)), "Repay Double In 14 Turns"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Repay Triple in 14 Turns"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Offer Nothing")});
            this.promiseRadioGroup.Size = new System.Drawing.Size(260, 133);
            this.promiseRadioGroup.TabIndex = 0;
            // 
            // moneyRadioGroup
            // 
            this.moneyRadioGroup.Location = new System.Drawing.Point(279, 13);
            this.moneyRadioGroup.Name = "moneyRadioGroup";
            this.moneyRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(10000, "10,000"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(20000, "20,000"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(100000, "100,000"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(500000, "500,000"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1000000, "1 Million")});
            this.moneyRadioGroup.Size = new System.Drawing.Size(222, 133);
            this.moneyRadioGroup.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make Request";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoanRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moneyRadioGroup);
            this.Controls.Add(this.promiseRadioGroup);
            this.Name = "LoanRequest";
            this.Text = "LoanRequest";
            ((System.ComponentModel.ISupportInitialize)(this.promiseRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyRadioGroup.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup promiseRadioGroup;
        private DevExpress.XtraEditors.RadioGroup moneyRadioGroup;
        private System.Windows.Forms.Button button1;

    }
}