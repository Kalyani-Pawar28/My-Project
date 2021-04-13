using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FogNode
{
	public partial class FogNodeForm : Form
	{
		private bool running = false;
		private String BASE_URL;
		private String TOKEN;
		private int count = 0;

		private bool isSimulation = true;

		public FogNodeForm()
		{
			InitializeComponent();
			buttonStart.Enabled = true;
			buttonStop.Enabled = false;

			chartPulse.ChartAreas[0].AxisY.Minimum = 40;
			chartTemp.ChartAreas[0].AxisY.Minimum = 90;

			chartPulse.Titles.Add("Pulse Rate");
			chartTemp.Titles.Add("Temperature");
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			BASE_URL = "http://" + textBoxIP.Text + ":" + textBoxPort.Text + "/api";
			TOKEN = textToken.Text;
			buttonStop.Enabled = true;
			buttonStart.Enabled = false;
			running = true;
			System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(MonitorThread));
			t.Start();
		}

		async public void MonitorThread()
		{
			HttpClient client = new HttpClient();
			Random random = new Random();


			while (running)
			{
				try
				{
					Console.WriteLine("Reading values");
					Thread.Sleep(1000);

					int bpm;
					float temp;

					if (isSimulation)
					{
						bpm = random.Next(60, 100);
						temp = random.Next(9500, 10100) / 100.0f;
					}
					else
					{

						Object[] values = ReadValues();
						bpm = (int)values[0];
						temp = (float)values[1];
					}

					int isnormal = 1;
					if (bpm < 60 || bpm > 100 || temp < 95 || temp > 100)
					{
						isnormal = 0;
					}

					labelBPM.Text = bpm.ToString();
					labelTemp.Text = temp.ToString();

					chartPulse.Series[0].Points.AddXY(count++, bpm);
					chartTemp.Series[0].Points.AddXY(count++, temp);

					chartPulse.ChartAreas[0].AxisX.Minimum = Math.Max(count - 50, 0);
					chartTemp.ChartAreas[0].AxisX.Minimum = Math.Max(count - 50, 0);


					String urlpart = TOKEN + "_" + bpm + "_" + temp + "_" + isnormal;
					urlpart = urlpart.Replace(".", "__");

					Console.WriteLine("Sending request");
					String url = BASE_URL + "/service/" + urlpart;
					Console.WriteLine(url);
					HttpResponseMessage result = await client.GetAsync(url);
					String resulttext = await result.Content.ReadAsStringAsync();
					Console.WriteLine(resulttext);
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
					running = false;
				}
			}
			buttonStart.Enabled = true;
			buttonStop.Enabled = false;
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			running = false;
			buttonStart.Enabled = true;
			buttonStop.Enabled = false;
		}

		public static Object[] ReadValues()
		{
			using (SerialPort port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One))
			{
				try
				{
					port.Open();

					string data = port.ReadLine();

					string value1 = data.Substring(5, 2);   // temp value
					string value2 = data.Substring(11, 2);     // heartbeat value

					return new object[] { int.Parse(value2), float.Parse(value1) };
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return new object[] { 0, 0f };
				}
			}
		}
	}
}
