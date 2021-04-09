using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedicalMonitoring
{
	public partial class LoginPatient : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btn_login_Click(object sender, EventArgs e)
		{
			String username = tb_username.Text;
			String password = tb_password.Text;

			Object []results = Database.CheckPatientLogin(username, password);
			if (results == null)
			{
				label_message.Text = "Invalid username or password";
			}
			else
			{
				int? patientid = results[0] as int?;
				String name = results[1] as String;
				String token = results[2] as String;

				Session["patientid"] = patientid;
				Session["name"] = name;
				Session["token"] = token;
				Response.Redirect("~/PatientHome.aspx");
			}
		}
	}
}
