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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
			this.btPause = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btSetting
			// 
			this.btSetting.Location = new System.Drawing.Point(3, 3);
			this.btSetting.Name = "btSetting";
			this.btSetting.Size = new System.Drawing.Size(55, 28);
			this.btSetting.TabIndex = 3;
			this.btSetting.Text = "Setting";
			this.btSetting.UseVisualStyleBackColor = true;
			this.btSetting.Click += new System.EventHandler(this.btSetting_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 11);
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
            "cos(x)",
            "x"});
			this.cbFunc.Location = new System.Drawing.Point(129, 8);
			this.cbFunc.Name = "cbFunc";
			this.cbFunc.Size = new System.Drawing.Size(129, 21);
			this.cbFunc.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(274, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Noise:";
			// 
			// tbNoise
			// 
			this.tbNoise.Location = new System.Drawing.Point(317, 8);
			this.tbNoise.Name = "tbNoise";
			this.tbNoise.Size = new System.Drawing.Size(129, 20);
			this.tbNoise.TabIndex = 7;
			// 
			// btStep
			// 
			this.btStep.Location = new System.Drawing.Point(3, 3);
			this.btStep.Name = "btStep";
			this.btStep.Size = new System.Drawing.Size(61, 28);
			this.btStep.TabIndex = 10;
			this.btStep.Text = "Step";
			this.btStep.UseVisualStyleBackColor = true;
			this.btStep.Click += new System.EventHandler(this.btStep_Click);
			// 
			// btRun
			// 
			this.btRun.Location = new System.Drawing.Point(70, 3);
			this.btRun.Name = "btRun";
			this.btRun.Size = new System.Drawing.Size(64, 28);
			this.btRun.TabIndex = 11;
			this.btRun.Text = "Run";
			this.btRun.UseVisualStyleBackColor = true;
			this.btRun.Click += new System.EventHandler(this.btRun_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(578, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Step:";
			// 
			// lbStep
			// 
			this.lbStep.AutoSize = true;
			this.lbStep.Location = new System.Drawing.Point(616, 15);
			this.lbStep.Name = "lbStep";
			this.lbStep.Size = new System.Drawing.Size(13, 13);
			this.lbStep.TabIndex = 13;
			this.lbStep.Text = "0";
			// 
			// btPlot
			// 
			this.btPlot.Location = new System.Drawing.Point(472, 3);
			this.btPlot.Name = "btPlot";
			this.btPlot.Size = new System.Drawing.Size(55, 28);
			this.btPlot.TabIndex = 3;
			this.btPlot.Text = "Plot";
			this.btPlot.UseVisualStyleBackColor = true;
			this.btPlot.Click += new System.EventHandler(this.btPlot_Click);
			// 
			// chart2
			// 
			chartArea11.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea11);
			this.chart2.Dock = System.Windows.Forms.DockStyle.Right;
			legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend11.Name = "Legend1";
			this.chart2.Legends.Add(legend11);
			this.chart2.Location = new System.Drawing.Point(498, 0);
			this.chart2.Name = "chart2";
			series21.ChartArea = "ChartArea1";
			series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series21.Legend = "Legend1";
			series21.Name = "Error";
			this.chart2.Series.Add(series21);
			this.chart2.Size = new System.Drawing.Size(379, 295);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart2";
			// 
			// chart1
			// 
			chartArea12.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea12);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
			legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend12.Name = "Legend1";
			this.chart1.Legends.Add(legend12);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red};
			series22.ChartArea = "ChartArea1";
			series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series22.Legend = "Legend1";
			series22.MarkerSize = 10;
			series22.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series22.Name = "Target";
			series22.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series22.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series23.ChartArea = "ChartArea1";
			series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series23.Legend = "Legend1";
			series23.Name = "Input";
			series24.ChartArea = "ChartArea1";
			series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series24.Legend = "Legend1";
			series24.Name = "Output";
			series24.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series24.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			this.chart1.Series.Add(series22);
			this.chart1.Series.Add(series23);
			this.chart1.Series.Add(series24);
			this.chart1.Size = new System.Drawing.Size(493, 295);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chart1);
			this.panel1.Controls.Add(this.chart2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(877, 295);
			this.panel1.TabIndex = 2;
			// 
			// btPause
			// 
			this.btPause.Location = new System.Drawing.Point(140, 3);
			this.btPause.Name = "btPause";
			this.btPause.Size = new System.Drawing.Size(64, 28);
			this.btPause.TabIndex = 11;
			this.btPause.Text = "Pause";
			this.btPause.UseVisualStyleBackColor = true;
			this.btPause.Click += new System.EventHandler(this.btPause_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btStep);
			this.panel2.Controls.Add(this.btRun);
			this.panel2.Controls.Add(this.btPause);
			this.panel2.Location = new System.Drawing.Point(669, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(207, 35);
			this.panel2.TabIndex = 14;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btPlot);
			this.panel3.Controls.Add(this.btSetting);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.tbNoise);
			this.panel3.Controls.Add(this.cbFunc);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(4, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(533, 35);
			this.panel3.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(877, 335);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.lbStep);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
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
		private System.Windows.Forms.Button btPause;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
	}
}

