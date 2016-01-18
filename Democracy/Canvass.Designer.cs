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
            this.SuspendLayout();
            // 
            // btnpalatina
            // 
            this.btnpalatina.Location = new System.Drawing.Point(12, 34);
            this.btnpalatina.Name = "btnpalatina";
            this.btnpalatina.Size = new System.Drawing.Size(75, 23);
            this.btnpalatina.TabIndex = 0;
            this.btnpalatina.Text = "Palatina";
            this.btnpalatina.UseVisualStyleBackColor = true;
            this.btnpalatina.Click += new System.EventHandler(this.button1_Click);
            // 
            // Canvass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnpalatina);
            this.Name = "Canvass";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpalatina;
    }
}