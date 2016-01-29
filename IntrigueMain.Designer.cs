namespace Intrigue
{
    partial class IntrigueMain
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedBarSeriesView fullStackedBarSeriesView1 = new DevExpress.XtraCharts.FullStackedBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedBarSeriesView fullStackedBarSeriesView2 = new DevExpress.XtraCharts.FullStackedBarSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedBarSeriesView fullStackedBarSeriesView3 = new DevExpress.XtraCharts.FullStackedBarSeriesView();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.FullStackedBarSeriesView fullStackedBarSeriesView4 = new DevExpress.XtraCharts.FullStackedBarSeriesView();
            DevExpress.XtraCharts.SideBySideFullStackedBarSeriesView sideBySideFullStackedBarSeriesView1 = new DevExpress.XtraCharts.SideBySideFullStackedBarSeriesView();
            this.label6 = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.turnLabel1 = new System.Windows.Forms.Label();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.orateButton = new System.Windows.Forms.Button();
            this.bribeButton = new System.Windows.Forms.Button();
            this.thugsButton = new System.Windows.Forms.Button();
            this.actionNameLabel = new System.Windows.Forms.Label();
            this.TurnAction = new System.Windows.Forms.Label();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.palatinePanel = new System.Windows.Forms.Panel();
            this.ActionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideFullStackedBarSeriesView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cash Flow";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(688, 46);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(35, 13);
            this.moneyLabel.TabIndex = 12;
            this.moneyLabel.Text = "label7";
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(566, 12);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 13;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(782, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "End Turn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turnLabel1
            // 
            this.turnLabel1.AutoSize = true;
            this.turnLabel1.Location = new System.Drawing.Point(790, 44);
            this.turnLabel1.Name = "turnLabel1";
            this.turnLabel1.Size = new System.Drawing.Size(51, 13);
            this.turnLabel1.TabIndex = 16;
            this.turnLabel1.Text = "turnLabel";
            // 
            // ActionPanel
            // 
            this.ActionPanel.Controls.Add(this.orateButton);
            this.ActionPanel.Controls.Add(this.bribeButton);
            this.ActionPanel.Controls.Add(this.thugsButton);
            this.ActionPanel.Controls.Add(this.actionNameLabel);
            this.ActionPanel.Location = new System.Drawing.Point(607, 327);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(207, 153);
            this.ActionPanel.TabIndex = 17;
            // 
            // orateButton
            // 
            this.orateButton.Location = new System.Drawing.Point(21, 106);
            this.orateButton.Name = "orateButton";
            this.orateButton.Size = new System.Drawing.Size(166, 23);
            this.orateButton.TabIndex = 3;
            this.orateButton.Text = "Orate";
            this.orateButton.UseVisualStyleBackColor = true;
            this.orateButton.Click += new System.EventHandler(this.orateButton_Click);
            // 
            // bribeButton
            // 
            this.bribeButton.Location = new System.Drawing.Point(21, 76);
            this.bribeButton.Name = "bribeButton";
            this.bribeButton.Size = new System.Drawing.Size(166, 23);
            this.bribeButton.TabIndex = 2;
            this.bribeButton.Text = "Bribe them!";
            this.bribeButton.UseVisualStyleBackColor = true;
            this.bribeButton.Click += new System.EventHandler(this.bribeButton_Click);
            // 
            // thugsButton
            // 
            this.thugsButton.Location = new System.Drawing.Point(21, 47);
            this.thugsButton.Name = "thugsButton";
            this.thugsButton.Size = new System.Drawing.Size(166, 23);
            this.thugsButton.TabIndex = 1;
            this.thugsButton.Text = "Send in the thugs";
            this.thugsButton.UseVisualStyleBackColor = true;
            this.thugsButton.Click += new System.EventHandler(this.thugsButton_Click);
            // 
            // actionNameLabel
            // 
            this.actionNameLabel.AutoSize = true;
            this.actionNameLabel.Location = new System.Drawing.Point(21, 15);
            this.actionNameLabel.Name = "actionNameLabel";
            this.actionNameLabel.Size = new System.Drawing.Size(35, 13);
            this.actionNameLabel.TabIndex = 0;
            this.actionNameLabel.Text = "label7";
            // 
            // TurnAction
            // 
            this.TurnAction.AutoSize = true;
            this.TurnAction.Location = new System.Drawing.Point(607, 295);
            this.TurnAction.Name = "TurnAction";
            this.TurnAction.Size = new System.Drawing.Size(228, 13);
            this.TurnAction.TabIndex = 18;
            this.TurnAction.Text = "You have not yet chosen an action for this turn";
            // 
            // chartControl1
            // 
            this.chartControl1.BackColor = System.Drawing.Color.Transparent;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(566, 72);
            this.chartControl1.Name = "chartControl1";
            series1.Name = "Player";
            series1.ShowInLegend = false;
            series1.View = fullStackedBarSeriesView1;
            series2.Name = "Cato";
            series2.ShowInLegend = false;
            series2.View = fullStackedBarSeriesView2;
            series3.Name = "Curio";
            series3.ShowInLegend = false;
            series3.View = fullStackedBarSeriesView3;
            series4.Name = "Lucius";
            series4.ShowInLegend = false;
            series4.View = fullStackedBarSeriesView4;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3,
        series4};
            this.chartControl1.SeriesTemplate.View = sideBySideFullStackedBarSeriesView1;
            this.chartControl1.Size = new System.Drawing.Size(300, 200);
            this.chartControl1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Intrigue.Properties.Resources.romemap;
            this.panel1.Controls.Add(this.palatinePanel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 532);
            this.panel1.TabIndex = 0;
            // 
            // palatinePanel
            // 
            this.palatinePanel.BackColor = System.Drawing.Color.Transparent;
            this.palatinePanel.BackgroundImage = global::Intrigue.Properties.Resources.romemap_palatina;
            this.palatinePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.palatinePanel.Location = new System.Drawing.Point(180, 252);
            this.palatinePanel.Name = "palatinePanel";
            this.palatinePanel.Size = new System.Drawing.Size(110, 137);
            this.palatinePanel.TabIndex = 0;
            // 
            // IntrigueMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 556);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.TurnAction);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.turnLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "IntrigueMain";
            this.Text = "IntrigueMain";
            this.ActionPanel.ResumeLayout(false);
            this.ActionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(fullStackedBarSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideFullStackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label turnLabel1;
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.Label actionNameLabel;
        private System.Windows.Forms.Label TurnAction;
        private System.Windows.Forms.Button orateButton;
        private System.Windows.Forms.Button bribeButton;
        private System.Windows.Forms.Button thugsButton;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel palatinePanel;
    }
}