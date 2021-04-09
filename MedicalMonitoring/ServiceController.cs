﻿using System;
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

		// GET api/<controller>/5
		public string Get(String id)
		{
			return "value"+id;
		}

		// POST api/<controller>
		public String Post([FromBody] string value)
		{
			return "[Received data " + value+"]";
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