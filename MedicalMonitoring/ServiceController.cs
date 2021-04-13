using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Web.Http;

namespace MedicalMonitoring
{
	public class ServiceController : ApiController
	{
		// GET api/<controller>
		public IEnumerable<string> Get()
		{
			return new string[] { "value1", "value2" };
		}

		private static char[] SEPARATORS = new char[] { '_' };
		// GET api/<controller>/5
		public string Get(String id)
		{
			id = id.Replace("__", ".");

			String[] tokens = id.Split(SEPARATORS);
			String token = tokens[0];
			int bpm = int.Parse(tokens[1]);
			float temp = float.Parse(tokens[2]);
			int isnormal = int.Parse(tokens[3]);

			Database.AddEntry(token, bpm, temp, isnormal);

			DataTable table = Database.GetPatientFromToken(token);
			if (table.Rows.Count > 0)
			{
				DataRow row = table.Rows[0];
				String name = row["name"] as String;
				String email = row["email"] as String;

				String text = "Patient Name : " + name + "<br/>";
				text += "Pulse : " + bpm + "<br/>";
				text += "Temperature : " + temp + "<br/>";

				SendEmail(email,text);
			}

			return "OK";
		}

		// POST api/<controller>
		public String Post([FromBody] string value)
		{
			return "[Received data " + value + "]";
		}

		// PUT api/<controller>/5
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<controller>/5
		public void Delete(int id)
		{
		}

		public static void SendEmail(string to, string htmlString)
		{
			try
			{
				MailMessage message = new MailMessage();
				SmtpClient smtp = new SmtpClient();
				message.From = new MailAddress("FromMailAddress");
				message.To.Add(new MailAddress(to));
				message.Subject = "Alert";
				message.IsBodyHtml = true; //to make message body as html
				message.Body = htmlString;
				smtp.Port = 587;
				smtp.Host = "smtp.gmail.com"; //for gmail host
				smtp.EnableSsl = true;
				smtp.UseDefaultCredentials = false;
				smtp.Credentials = new NetworkCredential("senderemail@gmail.com", "gmailpassword");
				smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
				smtp.Send(message);
			}
			catch (Exception) { }
		}
	}
}