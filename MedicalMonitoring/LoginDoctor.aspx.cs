using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedicalMonitoring
{
	public partial class LoginDoctor : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btn_login_Click(object sender, EventArgs e)
		{
			String username = tb_username.Text;
			String password = tb_password.Text;

			Object []results=Database.CheckDoctorLogin(username, password);


			if(results==null)
			{
				label_message.Text = "Invalid username or password";
			}
			else
			{
				int? doctorid = results[0] as int?;
				String name = results[1] as String;
				Session["doctorid"] = doctorid;
				Session["name"] = name;
				Response.Redirect("~/DoctorHome.aspx");
			}
		}
	}
}