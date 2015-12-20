namespace FunctionApproximation
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.btSetting = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbFunc = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNoise = new System.Windows.Forms.TextBox();
			this.btStep = new System.Windows.Forms.Button();
			this.btRun = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.lbStep = new System.Windows.Forms.Label();
			this.btPlot = new System.Windows.Forms.Button();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btSetting
			// 
			this.btSetting.Location = new System.Drawing.Point(8, 7);
			this.btSetting.Name = "btSetting";
			this.btSetting.Size = new System.Drawing.Size(55, 53);
			this.btSetting.TabIndex = 3;
			this.btSetting.Text = "Setting";
			this.btSetting.UseVisualStyleBackColor = true;
			this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Function:";
			// 
			// cbFunc
			// 
			this.cbFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFunc.FormattingEnabled = true;
			this.cbFunc.Items.AddRange(new object[] {
            "sin(x)",
            "cos(x)"});
			this.cbFunc.Location = new System.Drawing.Point(131, 14);
			this.cbFunc.Name = "cbFunc";
			this.cbFunc.Size = new System.Drawing.Size(129, 21);
			this.cbFunc.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(77, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Noise:";
			// 
			// tbNoise
			// 
			this.tbNoise.Location = new System.Drawing.Point(131, 40);
			this.tbNoise.Name = "tbNoise";
			this.tbNoise.Size = new System.Drawing.Size(129, 20);
			this.tbNoise.TabIndex = 7;
			// 
			// btStep
			// 
			this.btStep.Location = new System.Drawing.Point(461, 7);
			this.btStep.Name = "btStep";
			this.btStep.Size = new System.Drawing.Size(61, 53);
			this.btStep.TabIndex = 10;
			this.btStep.Text = "Step";
			this.btStep.UseVisualStyleBackColor = true;
			this.btStep.Click += new System.EventHandler(this.btStep_Click);
			// 
			// btRun
			// 
			this.btRun.Location = new System.Drawing.Point(528, 7);
			this.btRun.Name = "btRun";
			this.btRun.Size = new System.Drawing.Size(64, 53);
			this.btRun.TabIndex = 11;
			this.btRun.Text = "Run";
			this.btRun.UseVisualStyleBackColor = true;
			this.btRun.Click += new System.EventHandler(this.btRun_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(385, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Step:";
			// 
			// lbStep
			// 
			this.lbStep.AutoSize = true;
			this.lbStep.Location = new System.Drawing.Point(423, 47);
			this.lbStep.Name = "lbStep";
			this.lbStep.Size = new System.Drawing.Size(13, 13);
			this.lbStep.TabIndex = 13;
			this.lbStep.Text = "0";
			// 
			// btPlot
			// 
			this.btPlot.Location = new System.Drawing.Point(274, 7);
			this.btPlot.Name = "btPlot";
			this.btPlot.Size = new System.Drawing.Size(55, 53);
			this.btPlot.TabIndex = 3;
			this.btPlot.Text = "Plot";
			this.btPlot.UseVisualStyleBackColor = true;
			this.btPlot.Click += new System.EventHandler(this.btPlot_Click);
			// 
			// chart2
			// 
			chartArea7.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea7);
			this.chart2.Dock = System.Windows.Forms.DockStyle.Right;
			legend7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend7.Name = "Legend1";
			this.chart2.Legends.Add(legend7);
			this.chart2.Location = new System.Drawing.Point(498, 0);
			this.chart2.Name = "chart2";
			series13.ChartArea = "ChartArea1";
			series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series13.Legend = "Legend1";
			series13.Name = "Error";
			this.chart2.Series.Add(series13);
			this.chart2.Size = new System.Drawing.Size(379, 295);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart2";
			// 
			// chart1
			// 
			chartArea8.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea8);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
			legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend8.Name = "Legend1";
			this.chart1.Legends.Add(legend8);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red};
			series14.ChartArea = "ChartArea1";
			series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series14.Legend = "Legend1";
			series14.MarkerSize = 10;
			series14.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series14.Name = "Target";
			series14.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series14.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series15.ChartArea = "ChartArea1";
			series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series15.Legend = "Legend1";
			series15.Name = "Input";
			series16.ChartArea = "ChartArea1";
			series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series16.Legend = "Legend1";
			series16.Name = "Output";
			series16.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series16.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chart1.Series.Add(series14);
			this.chart1.Series.Add(series15);
			this.chart1.Series.Add(series16);
			this.chart1.Size = new System.Drawing.Size(493, 295);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chart1);
			this.panel1.Controls.Add(this.chart2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 232);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(877, 295);
			this.panel1.TabIndex = 2;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(8, 66);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(627, 160);
			this.richTextBox1.TabIndex = 14;
			this.richTextBox1.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(877, 527);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.lbStep);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btRun);
			this.Controls.Add(this.btStep);
			this.Controls.Add(this.tbNoise);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbFunc);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btPlot);
			this.Controls.Add(this.btSetting);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btSetting;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbFunc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbNoise;
		private System.Windows.Forms.Button btStep;
		private System.Windows.Forms.Button btRun;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbStep;
		private System.Windows.Forms.Button btPlot;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

