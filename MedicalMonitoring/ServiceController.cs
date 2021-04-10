using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
	}
}