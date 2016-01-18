namespace Intrigue.Democracy
{
    partial class Canvass
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
            this.btnpalatina = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpalatina
            // 
            this.btnpalatina.Location = new System.Drawing.Point(9, 28);
            this.btnpalatina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnpalatina.Name = "btnpalatina";
            this.btnpalatina.Size = new System.Drawing.Size(56, 19);
            this.btnpalatina.TabIndex = 0;
            this.btnpalatina.Text = "Palatina";
            this.btnpalatina.UseVisualStyleBackColor = true;
            this.btnpalatina.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Collina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Canvass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpalatina);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Canvass";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpalatina;
        private System.Windows.Forms.Button button1;
    }
}