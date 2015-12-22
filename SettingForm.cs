using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionApproximation.Properties;
using DemoNeuralNetwork.NeuralNetworks.LearningAlgorithms;


namespace FunctionApproximation
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			cbFunc.SelectedIndex = 0;
			cbNumHL.SelectedIndex = Settings.Default.NumHL - 1;
			cbPer.SelectedIndex = 0;
			cbTrain.SelectedIndex = 0;

			tbLayer1.Text = "" + Settings.Default.Layer1;
			tbLayer2.Text = "" + Settings.Default.Layer2;
			tbLayer3.Text = "" + Settings.Default.Layer3;

			tbIteration.Text = Settings.Default.Iteration + "";
			tbErr.Text = Settings.Default.Err + "";
			tbTimer.Text = Settings.Default.Timer + "";

			tbBeta.Text = Settings.Default.Beta + "";
			tbNuy.Text = Settings.Default.LearningRate + "";
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			Settings.Default.NumHL = cbNumHL.SelectedIndex + 1;
			
			try {
				Settings.Default.Layer1 = int.Parse(tbLayer1.Text);
				Settings.Default.Layer2 = int.Parse(tbLayer2.Text);
				Settings.Default.Layer3 = int.Parse(tbLayer3.Text);

				Settings.Default.Err = double.Parse(tbErr.Text);
				Settings.Default.Iteration = int.Parse(tbIteration.Text);
				Settings.Default.Timer = int.Parse(tbTimer.Text);

				Settings.Default.Learning = cbTrain.SelectedIndex;
				Settings.Default.Performance = cbPer.SelectedIndex;
				Settings.Default.Function = cbFunc.SelectedIndex;

				Settings.Default.Beta = double.Parse(tbBeta.Text);
				Settings.Default.LearningRate = double.Parse(tbNuy.Text);

				Settings.Default.Save();
				this.Close();
			}
			catch
			{
				MessageBox.Show("Can't save setting. Please check it again.");
			}
		}

		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbNumHL_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cbNumHL.SelectedIndex)
			{
				case 0:
					label4.Visible = label5.Visible = tbLayer2.Visible = tbLayer3.Visible = false;
					break;
				case 1:
					label5.Visible = tbLayer3.Visible = false;
					label4.Visible = tbLayer2.Visible = true;
					break;
				default:
					label4.Visible = label5.Visible = tbLayer2.Visible = tbLayer3.Visible = true;
					break;
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			(new About()).Show();
		}
	}
}
