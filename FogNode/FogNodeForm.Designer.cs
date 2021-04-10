namespace FogNode
{
	partial class FogNodeForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textToken = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBoxIP = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.buttonStop = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelTemp = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labelBPM = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(425, 40);
			this.label1.TabIndex = 0;
			this.label1.Text = "Patient Health Monitoring";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 59);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Token";
			// 
			// textToken
			// 
			this.textToken.Location = new System.Drawing.Point(105, 56);
			this.textToken.Name = "textToken";
			this.textToken.Size = new System.Drawing.Size(321, 22);
			this.textToken.TabIndex = 2;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(432, 56);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.textBoxPort);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.textBoxIP);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.buttonStop);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.buttonStart);
			this.panel1.Controls.Add(this.textToken);
			this.panel1.Location = new System.Drawing.Point(12, 43);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(860, 96);
			this.panel1.TabIndex = 4;
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(392, 14);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(171, 22);
			this.textBoxPort.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(306, 17);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(80, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "Server Port";
			// 
			// textBoxIP
			// 
			this.textBoxIP.Location = new System.Drawing.Point(125, 14);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(171, 22);
			this.textBoxIP.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 17);
			this.label7.TabIndex = 5;
			this.label7.Text = "Server Address";
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(513, 56);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(75, 23);
			this.buttonStop.TabIndex = 4;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.labelTemp);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.labelBPM);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(12, 145);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(860, 134);
			this.panel2.TabIndex = 5;
			// 
			// labelTemp
			// 
			this.labelTemp.AutoSize = true;
			this.labelTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTemp.Location = new System.Drawing.Point(282, 64);
			this.labelTemp.MinimumSize = new System.Drawing.Size(200, 0);
			this.labelTemp.Name = "labelTemp";
			this.labelTemp.Size = new System.Drawing.Size(200, 48);
			this.labelTemp.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(257, 46);
			this.label5.TabIndex = 2;
			this.label5.Text = "Temperature";
			// 
			// labelBPM
			// 
			this.labelBPM.AutoSize = true;
			this.labelBPM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBPM.Location = new System.Drawing.Point(282, 9);
			this.labelBPM.MinimumSize = new System.Drawing.Size(200, 0);
			this.labelBPM.Name = "labelBPM";
			this.labelBPM.Size = new System.Drawing.Size(200, 48);
			this.labelBPM.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(225, 46);
			this.label3.TabIndex = 0;
			this.label3.Text = "Pulse Rate";
			// 
			// FogNodeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 292);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(200, 47);
			this.Name = "FogNodeForm";
			this.Text = "FogNodeForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textToken;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelTemp;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labelBPM;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxPort;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBoxIP;
		private System.Windows.Forms.Label label7;
	}
}