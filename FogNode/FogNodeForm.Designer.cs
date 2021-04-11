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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
			this.chartPulse = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPulse)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(348, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "Patient Health Monitoring";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 48);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter Token";
			// 
			// textToken
			// 
			this.textToken.Location = new System.Drawing.Point(79, 46);
			this.textToken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textToken.Name = "textToken";
			this.textToken.Size = new System.Drawing.Size(242, 20);
			this.textToken.TabIndex = 2;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(324, 46);
			this.buttonStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(56, 19);
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
			this.panel1.Location = new System.Drawing.Point(9, 35);
			this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(646, 78);
			this.panel1.TabIndex = 4;
			// 
			// textBoxPort
			// 
			this.textBoxPort.Location = new System.Drawing.Point(294, 11);
			this.textBoxPort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(129, 20);
			this.textBoxPort.TabIndex = 8;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(230, 14);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Server Port";
			// 
			// textBoxIP
			// 
			this.textBoxIP.Location = new System.Drawing.Point(94, 11);
			this.textBoxIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.textBoxIP.Name = "textBoxIP";
			this.textBoxIP.Size = new System.Drawing.Size(129, 20);
			this.textBoxIP.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 14);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 13);
			this.label7.TabIndex = 5;
			this.label7.Text = "Server Address";
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(385, 46);
			this.buttonStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(56, 19);
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
			this.panel2.Location = new System.Drawing.Point(9, 118);
			this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(646, 109);
			this.panel2.TabIndex = 5;
			// 
			// labelTemp
			// 
			this.labelTemp.AutoSize = true;
			this.labelTemp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTemp.Location = new System.Drawing.Point(212, 52);
			this.labelTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTemp.MinimumSize = new System.Drawing.Size(150, 0);
			this.labelTemp.Name = "labelTemp";
			this.labelTemp.Size = new System.Drawing.Size(150, 39);
			this.labelTemp.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 52);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(211, 37);
			this.label5.TabIndex = 2;
			this.label5.Text = "Temperature";
			// 
			// labelBPM
			// 
			this.labelBPM.AutoSize = true;
			this.labelBPM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelBPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBPM.Location = new System.Drawing.Point(212, 7);
			this.labelBPM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelBPM.MinimumSize = new System.Drawing.Size(150, 0);
			this.labelBPM.Name = "labelBPM";
			this.labelBPM.Size = new System.Drawing.Size(150, 39);
			this.labelBPM.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 7);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(181, 37);
			this.label3.TabIndex = 0;
			this.label3.Text = "Pulse Rate";
			// 
			// chartPulse
			// 
			chartArea1.Name = "ChartArea1";
			this.chartPulse.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chartPulse.Legends.Add(legend1);
			this.chartPulse.Location = new System.Drawing.Point(12, 232);
			this.chartPulse.Name = "chartPulse";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Color = System.Drawing.Color.Black;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartPulse.Series.Add(series1);
			this.chartPulse.Size = new System.Drawing.Size(639, 197);
			this.chartPulse.TabIndex = 6;
			this.chartPulse.Text = "chart1";
			title1.Name = "Pulse Rate";
			this.chartPulse.Titles.Add(title1);
			// 
			// chartTemp
			// 
			chartArea2.Name = "ChartArea1";
			this.chartTemp.ChartAreas.Add(chartArea2);
			legend2.Enabled = false;
			legend2.Name = "Legend1";
			this.chartTemp.Legends.Add(legend2);
			this.chartTemp.Location = new System.Drawing.Point(12, 435);
			this.chartTemp.Name = "chartTemp";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series2.Color = System.Drawing.Color.Red;
			series2.Legend = "Legend1";
			series2.Name = "Series1";
			this.chartTemp.Series.Add(series2);
			this.chartTemp.Size = new System.Drawing.Size(643, 204);
			this.chartTemp.TabIndex = 7;
			this.chartTemp.Text = "chart2";
			// 
			// FogNodeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 651);
			this.Controls.Add(this.chartTemp);
			this.Controls.Add(this.chartPulse);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.MinimumSize = new System.Drawing.Size(153, 45);
			this.Name = "FogNodeForm";
			this.Text = "FogNodeForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartPulse)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
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
		private System.Windows.Forms.DataVisualization.Charting.Chart chartPulse;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
	}
}