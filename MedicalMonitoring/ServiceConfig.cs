using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;
using System.Web.Http;

namespace MedicalMonitoring
{
	public class ServiceConfig
	{
		public static void Register(HttpConfiguration config)
		{
			// Web API routes

			config.Formatters.Clear();
			config.Formatters.Add(new JsonMediaTypeFormatter());

			config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/plain"));

			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);
		}
	}
}