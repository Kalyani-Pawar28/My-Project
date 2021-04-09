using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedicalMonitoring;
using MySql.Data.MySqlClient;

namespace Patient_Health_Monitoring_System
{
	public partial class LoginPage : System.Web.UI.Page
	{
		public static string passuserid = "";
		protected void Page_Load(object sender, EventArgs e)
		{
			btnCancel.ServerClick += new EventHandler(btnCancel_Click);
			btnLogin.ServerClick += new EventHandler(btnLogin_Click);
		}
		protected void btnCancel_Click(object sender, EventArgs e)
		{
			Response.Redirect("HomePage.aspx");
		}
		protected void btnLogin_Click(object sender, EventArgs e)
		{
			try
			{
				String username, pass;
				username = txt_username.Value;
				pass = txt_pass.Value;

				using (var conn=Database.Connection)
				{

					String qr = "select Patient_Id,Password from PatientRegister where Patient_Id=@i AND Password=@p";
					using (MySqlCommand cmnd = new MySqlCommand(qr, conn))
					{
						cmnd.Parameters.AddWithValue("@i", username.ToString());
						cmnd.Parameters.AddWithValue("@p", pass.ToString());


						using (MySqlDataReader rdr = cmnd.ExecuteReader())
						{
							if (rdr.HasRows)
							{
								passuserid = username;
								Response.Redirect("WelcomePage.aspx");
							}
							else
							{
								Response.Write("<script>alert('Incorrect Patient ID or Password.')</script>");
							}
						}
					}
				}
			}
			catch (Exception exx)
			{
				// Response.Write(exx);
				Response.Write("<script>alert('Exception Occured in Login Page'" + exx.Message + "'')</script>");
			}
		}
	}
}