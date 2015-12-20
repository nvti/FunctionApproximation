using DemoNeuralNetwork.NeuralNetworks;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FunctionApproximation.Properties;
using DemoNeuralNetwork.NeuralNetworks.ActivationFunctions;
using DemoNeuralNetwork.NeuralNetworks.Performances;
using DemoNeuralNetwork.NeuralNetworks.LearningAlgorithms;

namespace FunctionApproximation
{
	public partial class MainForm : Form
	{
		Series series_input, series_output, series_target, series_error;
		List<List<double>> list_input = new List<List<double>>();
		List<List<double>> list_ex_output = new List<List<double>>();

		NeuralNetwork myNN;

		public MainForm()
		{
			InitializeComponent();
			series_input = chart1.Series.FindByName("Input");
			series_output = chart1.Series.FindByName("Output");
			series_target = chart1.Series.FindByName("Target");
			series_error = chart2.Series.FindByName("Error");
		}

		private void btSetting_Click(object sender, EventArgs e)
		{
			var frm = new SettingForm();
			frm.Show();
		}

		private void btStep_Click(object sender, EventArgs e)
		{
			myNN.La.LearnStep();
			richTextBox1.Text = myNN.PrintInfo();
			PlotOutput();

			myNN.La.Iter++;
			lbStep.Text = myNN.La.Iter + "";
		}

		private void btRun_Click(object sender, EventArgs e)
		{
			myNN.Learn();
			PlotOutput();
			lbStep.Text = myNN.La.Iter + "";
		}

		private void PlotOutput()
		{
			series_output.Points.Clear();
			for(int i = 0; i < list_input.Count; i++)
			{
				myNN.CreateInput(list_input[i]);

				series_output.Points.Add(new DataPoint(list_input[i][0], myNN.Outputs[0]));
			}

			series_error.Points.Add(myNN.La.Error);
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

			ActivationFunc ac = (ActivationFunc)Settings.Default.Function;

			myNN = new NeuralNetwork(n_neuron, nlayer, l, ac);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			cbFunc.SelectedIndex = 0;
			tbNoise.Text = Settings.Default.Noise + "";
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
				list_input.Clear();
				list_ex_output.Clear();

				Random rand = new Random();
				int N = 40;
				switch ((string)cbFunc.SelectedItem)
				{
					case "sin(x)":
						for (int i = 0; i < N; i++)
						{
							double x = 4 * Math.PI * i / N;
							double f = Math.Sin(x);
							double t = f + (2 * rand.NextDouble() - 1) * noise;

							series_input.Points.Add(new DataPoint(x, f));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { t });
						}
						break;
					default:
						for (int i = 0; i < N; i++)
						{
							double x = 4 * Math.PI * i / N;
							double f = Math.Cos(x);
							double t = f + (2 * rand.NextDouble() - 1) * noise;

							series_input.Points.Add(new DataPoint(x, f));
							series_target.Points.Add(new DataPoint(x, t));

							list_input.Add(new List<double> { x });
							list_ex_output.Add(new List<double> { t });
						}
						break;
				}

				CreateNeuralNetwork();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
