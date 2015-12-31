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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btSetting = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbFunc = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbNoise = new System.Windows.Forms.TextBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.lbStep = new System.Windows.Forms.Label();
			this.btPlot = new System.Windows.Forms.Button();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btStep = new System.Windows.Forms.Button();
			this.btRun = new System.Windows.Forms.Button();
			this.btPause = new System.Windows.Forms.Button();
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
			this.btSetting.Text = "Option";
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
            "x",
            "x^2",
            "|x|",
            "log(x)",
            "sqrt(x)",
            "sin(x)",
            "cos(x)"});
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
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(572, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Step:";
			// 
			// lbStep
			// 
			this.lbStep.AutoSize = true;
			this.lbStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbStep.Location = new System.Drawing.Point(625, 22);
			this.lbStep.Name = "lbStep";
			this.lbStep.Size = new System.Drawing.Size(18, 20);
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
			chartArea3.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea3);
			this.chart2.Dock = System.Windows.Forms.DockStyle.Right;
			legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend3.Name = "Legend1";
			this.chart2.Legends.Add(legend3);
			this.chart2.Location = new System.Drawing.Point(498, 0);
			this.chart2.Name = "chart2";
			series6.ChartArea = "ChartArea1";
			series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series6.Legend = "Legend1";
			series6.Name = "Error";
			this.chart2.Series.Add(series6);
			this.chart2.Size = new System.Drawing.Size(379, 295);
			this.chart2.TabIndex = 1;
			this.chart2.Text = "chart2";
			// 
			// chart1
			// 
			chartArea4.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea4);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
			legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend4.Name = "Legend1";
			this.chart1.Legends.Add(legend4);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Black};
			series7.ChartArea = "ChartArea1";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
			series7.Legend = "Legend1";
			series7.MarkerSize = 10;
			series7.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
			series7.Name = "Target";
			series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series8.ChartArea = "ChartArea1";
			series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series8.Legend = "Legend1";
			series8.Name = "Input";
			series9.ChartArea = "ChartArea1";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series9.Legend = "Legend1";
			series9.Name = "Output";
			series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series9.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
			series10.ChartArea = "ChartArea1";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series10.Legend = "Legend1";
			series10.Name = "Error";
			this.chart1.Series.Add(series7);
			this.chart1.Series.Add(series8);
			this.chart1.Series.Add(series9);
			this.chart1.Series.Add(series10);
			this.chart1.Size = new System.Drawing.Size(493, 295);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chart1);
			this.panel1.Controls.Add(this.chart2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 56);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(877, 295);
			this.panel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btStep);
			this.panel2.Controls.Add(this.btRun);
			this.panel2.Controls.Add(this.btPause);
			this.panel2.Location = new System.Drawing.Point(714, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(162, 51);
			this.panel2.TabIndex = 14;
			// 
			// btStep
			// 
			this.btStep.Image = ((System.Drawing.Image)(resources.GetObject("btStep.Image")));
			this.btStep.Location = new System.Drawing.Point(3, 1);
			this.btStep.Name = "btStep";
			this.btStep.Size = new System.Drawing.Size(48, 48);
			this.btStep.TabIndex = 10;
			this.btStep.UseVisualStyleBackColor = true;
			this.btStep.Click += new System.EventHandler(this.btStep_Click);
			// 
			// btRun
			// 
			this.btRun.Image = global::FunctionApproximation.Properties.Resources.play;
			this.btRun.Location = new System.Drawing.Point(57, 1);
			this.btRun.Name = "btRun";
			this.btRun.Size = new System.Drawing.Size(48, 48);
			this.btRun.TabIndex = 11;
			this.btRun.UseVisualStyleBackColor = true;
			this.btRun.Click += new System.EventHandler(this.btRun_Click);
			// 
			// btPause
			// 
			this.btPause.Image = global::FunctionApproximation.Properties.Resources.pause1;
			this.btPause.Location = new System.Drawing.Point(111, 1);
			this.btPause.Name = "btPause";
			this.btPause.Size = new System.Drawing.Size(48, 49);
			this.btPause.TabIndex = 11;
			this.btPause.UseVisualStyleBackColor = true;
			this.btPause.Click += new System.EventHandler(this.btPause_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btPlot);
			this.panel3.Controls.Add(this.btSetting);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.tbNoise);
			this.panel3.Controls.Add(this.cbFunc);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Location = new System.Drawing.Point(12, 11);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(533, 35);
			this.panel3.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(877, 351);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.lbStep);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Function Approximation";
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

