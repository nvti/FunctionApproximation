namespace FunctionApproximation
{
	partial class SettingForm
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
			this.btOK = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cbNumHL = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbTrain = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbLayer1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbLayer2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbLayer3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbPer = new System.Windows.Forms.ComboBox();
			this.cbFunc = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.btCancel = new System.Windows.Forms.Button();
			this.tbErr = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbTimer = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbIteration = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btOK
			// 
			this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btOK.Location = new System.Drawing.Point(124, 198);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(76, 23);
			this.btOK.TabIndex = 0;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Hidden layer:";
			// 
			// cbNumHL
			// 
			this.cbNumHL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbNumHL.FormattingEnabled = true;
			this.cbNumHL.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
			this.cbNumHL.Location = new System.Drawing.Point(100, 6);
			this.cbNumHL.Name = "cbNumHL";
			this.cbNumHL.Size = new System.Drawing.Size(121, 21);
			this.cbNumHL.TabIndex = 2;
			this.cbNumHL.SelectedIndexChanged += new System.EventHandler(this.cbNumHL_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Training:";
			// 
			// cbTrain
			// 
			this.cbTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTrain.FormattingEnabled = true;
			this.cbTrain.Items.AddRange(new object[] {
            "Back Propagation"});
			this.cbTrain.Location = new System.Drawing.Point(100, 60);
			this.cbTrain.Name = "cbTrain";
			this.cbTrain.Size = new System.Drawing.Size(121, 21);
			this.cbTrain.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(254, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Layer 1:";
			// 
			// tbLayer1
			// 
			this.tbLayer1.Location = new System.Drawing.Point(302, 6);
			this.tbLayer1.Name = "tbLayer1";
			this.tbLayer1.Size = new System.Drawing.Size(100, 20);
			this.tbLayer1.TabIndex = 6;
			this.tbLayer1.Text = "20";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(254, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Layer 2:";
			this.label4.Visible = false;
			// 
			// tbLayer2
			// 
			this.tbLayer2.Location = new System.Drawing.Point(302, 32);
			this.tbLayer2.Name = "tbLayer2";
			this.tbLayer2.Size = new System.Drawing.Size(100, 20);
			this.tbLayer2.TabIndex = 6;
			this.tbLayer2.Text = "0";
			this.tbLayer2.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(254, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(45, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Layer 3:";
			this.label5.Visible = false;
			// 
			// tbLayer3
			// 
			this.tbLayer3.Location = new System.Drawing.Point(302, 58);
			this.tbLayer3.Name = "tbLayer3";
			this.tbLayer3.Size = new System.Drawing.Size(100, 20);
			this.tbLayer3.TabIndex = 6;
			this.tbLayer3.Text = "0";
			this.tbLayer3.Visible = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(11, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(70, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "Performance:";
			// 
			// cbPer
			// 
			this.cbPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPer.FormattingEnabled = true;
			this.cbPer.Items.AddRange(new object[] {
            "MSE"});
			this.cbPer.Location = new System.Drawing.Point(100, 87);
			this.cbPer.Name = "cbPer";
			this.cbPer.Size = new System.Drawing.Size(121, 21);
			this.cbPer.TabIndex = 4;
			// 
			// cbFunc
			// 
			this.cbFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFunc.FormattingEnabled = true;
			this.cbFunc.Items.AddRange(new object[] {
            "Sigmoid Function"});
			this.cbFunc.Location = new System.Drawing.Point(100, 33);
			this.cbFunc.Name = "cbFunc";
			this.cbFunc.Size = new System.Drawing.Size(121, 21);
			this.cbFunc.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(11, 36);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(84, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Activation Func:";
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.Location = new System.Drawing.Point(221, 198);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(76, 23);
			this.btCancel.TabIndex = 0;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// tbErr
			// 
			this.tbErr.Location = new System.Drawing.Point(100, 140);
			this.tbErr.Name = "tbErr";
			this.tbErr.Size = new System.Drawing.Size(121, 20);
			this.tbErr.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 143);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Err threshold:";
			// 
			// tbTimer
			// 
			this.tbTimer.Location = new System.Drawing.Point(100, 166);
			this.tbTimer.Name = "tbTimer";
			this.tbTimer.Size = new System.Drawing.Size(121, 20);
			this.tbTimer.TabIndex = 14;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 169);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Timer interval:";
			// 
			// tbIteration
			// 
			this.tbIteration.Location = new System.Drawing.Point(100, 114);
			this.tbIteration.Name = "tbIteration";
			this.tbIteration.Size = new System.Drawing.Size(121, 20);
			this.tbIteration.TabIndex = 15;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 117);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(71, 13);
			this.label10.TabIndex = 12;
			this.label10.Text = "Max Iteration:";
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(418, 228);
			this.Controls.Add(this.tbErr);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.tbTimer);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.tbIteration);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbLayer3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbLayer2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbLayer1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbFunc);
			this.Controls.Add(this.cbPer);
			this.Controls.Add(this.cbTrain);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbNumHL);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOK);
			this.MaximizeBox = false;
			this.Name = "SettingForm";
			this.Text = "SettingForm";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbTrain;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbLayer1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbLayer2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbLayer3;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbPer;
		private System.Windows.Forms.ComboBox cbFunc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.ComboBox cbNumHL;
		private System.Windows.Forms.TextBox tbErr;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbTimer;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbIteration;
		private System.Windows.Forms.Label label10;
	}
}