using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedicalMonitoring
{
	public partial class DoctorHome : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(Session["doctorid"]==null)
			{
				Response.Redirect("/LoginDoctor.aspx");
				return;
			}
		}
	}
}