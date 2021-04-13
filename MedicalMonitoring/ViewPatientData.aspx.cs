using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedicalMonitoring
{
	public partial class ViewPatientData : System.Web.UI.Page
	{
		public DataTable table;

		protected void Page_Load(object sender, EventArgs e)
		{
			if (Request["patientid"] == null)
			{
				Response.Redirect("~/DoctorHome.aspx");
				return;
			}
			int patientid = int.Parse(Request["patientid"]);
			table = Database.GetPatientData(patientid);
			gridviewData.DataSource = table;
			gridviewData.DataBind();
		}
	}
}