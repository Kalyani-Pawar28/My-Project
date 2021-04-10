using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FogNode
{
	class Program
	{
		private static bool running = true;
		private const string BASE_URL = "http://localhost:63162/api";

		static void Main(string[] args)
		{
			Form.CheckForIllegalCrossThreadCalls = false;
			Application.Run(new FogNodeForm());
		}
		static void Main2(string[] args)
		{
			Console.WriteLine("Starting Fog Node...");


			System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(MonitorThread));
			t.Start();

			Console.WriteLine("Fog Node Started");

			while (true)
			{
				string ch = Console.ReadLine();
				if (ch == "q" || ch == "Q")
				{
					running = false;
					break;
				}
			}
			Console.WriteLine("Shutting down fog node");
		}

		async public static void MonitorThread()
		{
			HttpClient client = new HttpClient();

			while (running)
			{
				Console.WriteLine("Reading values");
				Thread.Sleep(5000);

				StringContent requestdata = new StringContent("abcd1:efgh2");
				Console.WriteLine("Sending request");
				HttpResponseMessage result = await client.PostAsync(BASE_URL + "/service", requestdata);
				String resulttext=await result.Content.ReadAsStringAsync();
				Console.WriteLine(resulttext);
			}
		}
	}
}
