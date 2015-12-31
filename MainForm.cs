using NeuralNetwork;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FunctionApproximation.Properties;
using NeuralNetwork.ActivationFunctions;
using NeuralNetwork.Performances;
using NeuralNetwork.LearningAlgorithms;
using NeuralNetwork.Lists;

namespace FunctionApproximation
{
	public partial class MainForm : Form
	{
		Series series_input, series_output, series_target, series_Learnerror, series_error;
		List<List<double>> list_input = new List<List<double>>();
		List<List<double>> list_ex_output = new List<List<double>>();

		double scale = 1, delta = 0;
		NNetwork myNN;

		public MainForm()
		{
			InitializeComponent();
			series_input = chart1.Series.FindByName("Input");
			series_output = chart1.Series.FindByName("Output");
			series_target = chart1.Series.FindByName("Target");
			series_error = chart1.Series.FindByName("Error");

			series_Learnerror = chart2.Series.FindByName("Error");
		}

		private void btSetting_Click(object sender, EventArgs e)
		{
			panel2.Enabled = false;
			var frm = new SettingForm();
			frm.ShowDialog();
		}

		private void btStep_Click(object sender, EventArgs e)
		{
			myNN.La.LearnStep();
			//richTextBox1.Text = myNN.PrintInfo();
			PlotOutput();

			lbStep.Text = myNN.La.Iter + "";
		}

		private void btRun_Click(object sender, EventArgs e)
		{
			timer1.Interval = Settings.Default.Timer;
			timer1.Enabled = true;
			btStep.Enabled = false;
			btRun.Enabled = false;
			btPause.Enabled = true;
			panel3.Enabled = false;
		}

		private void PlotOutput()
		{
			series_output.Points.Clear();
			series_error.Points.Clear();

			for(int i = 0; i < list_input.Count; i++)
			{
				myNN.InputLayer = list_input[i];

				series_output.Points.Add(new DataPoint(list_input[i][0], myNN.Outputs[0] * scale - delta));
				series_error.Points.Add(new DataPoint(list_input[i][0], (myNN.Outputs[0] - list_ex_output[i][0])* scale));
			}

			if(series_Learnerror.Points.Count > 800)
				series_Learnerror.Points.RemoveAt(0);
			series_Learnerror.Points.Add(myNN.La.Error);
			chart2.ResetAutoValues();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (myNN.La.Iter < myNN.La.MaxIteration && myNN.La.Error > myNN.La.ErrorThreshold)
				Invoke(new EventHandler(btStep_Click));
			else
			{
				timer1.Enabled = false;
				btStep.Enabled = false;
				btRun.Enabled = false;
				btPause.Enabled = false;
				panel3.Enabled = true;
				MessageBox.Show("Done!");
			}
		}

		private void btPause_Click(object sender, EventArgs e)
		{
			timer1.Enabled = false;
			btStep.Enabled = true;
			btRun.Enabled = true;
			btPause.Enabled = false;
			panel3.Enabled = true;
		}

		private void CreateNeuralNetwork()
		{
			int nlayer = Settings.Default.NumHL + 2;
			List<int> n_neuron = new List<int>();

			n_neuron.Add(1);
			n_neuron.Add(Settings.Default.Layer1);
			if (nlayer > 3) n_neuron.Add(Settings.Default.Layer2);
			if (nlayer > 4) n_neuron.Add(Settings.Default.Layer3);
			n_neuron.Add(1);

			LearningAlthm la = (LearningAlthm)Settings.Default.Learning;
			LearningAlgorithm l = LearningAlgorithm.Create(la);
			Perform per = (Perform)Settings.Default.Performance;
			l.Per = Performance.Create(per);
			l.MaxIteration = Settings.Default.Iteration;
			l.ErrorThreshold = Settings.Default.Err;
			l.Inputs = list_input;
			l.Outputs = list_ex_output;
			if(l is BackPropagationLearningAlgorithm)
			{
				((BackPropagationLearningAlgorithm)l).Beta = Settings.Default.Beta;
				((BackPropagationLearningAlgorithm)l).Nuy = Settings.Default.LearningRate;
			}

			ActivationFunc ac = (ActivationFunc)Settings.Default.Function;

			myNN = new NNetwork(n_neuron, nlayer, l, ac);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			cbFunc.SelectedIndex = 0;
			tbNoise.Text = Settings.Default.Noise + "";
			panel2.Enabled = false;
			btPause.Enabled = false;
		}

		private void btPlot_Click(object sender, EventArgs e)
		{
			try
			{
				double noise = double.Parse(tbNoise.Text);
				Settings.Default.Noise = noise;
				Settings.Default.Save();

				series_input.Points.Clear();
				series_target.Points.Clear();
				series_output.Points.Clear();
				series_error.Points.Clear();
				series_Learnerror.Points.Clear();

				list_input.Clear();
				list_ex_output.Clear();

				Random rand = new Random();
				int N = 40;
				switch ((string)cbFunc.SelectedItem)
				{
					case "sin(x)":
						scale = 4;
						delta = 2;
						for (int i = 0; i < N; i++)
						{
							double x = 2 * Math.PI * i / N;
							double f = Math.Sin(x);
							double t = f + (2 * rand.NextDouble() - 1) * noise * scale;

							series_input.Points.Add(new DataPoint(x, f));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { (t + delta) / scale });
						}
						break;
					case "x":
						scale = 5;
						delta = 0;
						for(int i = 0; i < N; i++)
						{
							double x = 4 * (double)i / N;
							double t = x + (2 * rand.NextDouble() - 1) * noise * scale;
							series_input.Points.Add(new DataPoint(x, x));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { (t + delta) / scale });
						}
						break;
					case "|x|":
						scale = 2.5;
						delta = 0;
						for (int i = -N / 2; i < N / 2; i++)
						{
							double x = 4 * (double)i / N;
							double f = Math.Abs(x);
							double t = f + (2 * rand.NextDouble() - 1) * noise * scale;
							series_input.Points.Add(new DataPoint(x, f));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { (t + delta) / scale });
						}
						break;
					case "sqrt(x)":
						scale = 2;
						delta = 0;
						for (int i = 1; i <= N; i++)
						{
							double x = 4 * (double)i / N;
							double f = Math.Sqrt(x);
							double t = f + (2 * rand.NextDouble() - 1) * noise * scale;

							series_input.Points.Add(new DataPoint(x, f));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { (t + delta) / scale });
						}
						break;
					case "x^2":
						scale = 4;
						delta = 0;
						for (int i = -N/2; i < N/2; i++)
						{
							double x = 4 * (double)i / N;
							double f = x * x;
							double t = f + (2 * rand.NextDouble() - 1) * noise * scale;

							series_input.Points.Add(new DataPoint(x, f));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { (t + delta) / scale });
						}
						break;
					case "log(x)":
						scale = 1;
						delta = 0;
						for (int i = 0; i < N; i++)
						{
							double x = 8 * (double)i / N + 1;
							double f = Math.Log10(x);
							double t = f + (2 * rand.NextDouble() - 1) * noise * scale;

							series_input.Points.Add(new DataPoint(x, f));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { (t + delta) / scale });
						}
						break;
					default:
						scale = 4;
						delta = 2;
						for (int i = 0; i < N; i++)
						{
							double x = 2 * Math.PI * i / N;
							double f = Math.Cos(x);
							double t = f + (2 * rand.NextDouble() - 1) * noise * scale;

							series_input.Points.Add(new DataPoint(x, f));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { (t + delta) / scale });
						}
						break;
				}

				CreateNeuralNetwork();
				panel2.Enabled = true;
				btStep.Enabled = true;
				btRun.Enabled = true;
				btPause.Enabled = false;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
