using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedicalMonitoring
{
	public partial class PatientHome : System.Web.UI.Page
	{
		public DataTable table;
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["patientid"] == null)
			{
				Response.Redirect("~/LoginPatient.aspx");
				return;
			}

			int patientid = (int)Session["patientid"];
			table = Database.GetPatientData(patientid);

			gridviewData.DataSource = table;
			gridviewData.DataBind();

		}
	}
}