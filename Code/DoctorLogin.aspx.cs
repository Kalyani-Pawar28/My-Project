using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


namespace Patient_Health_Monitoring_System
{
    public partial class DoctorLogin : System.Web.UI.Page
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
                String scon = @"datasource=localhost;port=3306;username=root;password=admin;database=iothealthdatabase";
                MySqlConnection conn = new MySqlConnection(scon);
                String qr = "select Doctor_Id ,Password from doctorregister where Doctor_Id =@i AND Password=@p";
                MySqlCommand cmnd = new MySqlCommand(qr, conn);
                cmnd.Parameters.AddWithValue("@i", username.ToString());
                cmnd.Parameters.AddWithValue("@p", pass.ToString());
                conn.Open();
                MySqlDataReader rdr = cmnd.ExecuteReader();
                if (rdr.HasRows)
                {
                    passuserid = username;
                    Response.Redirect("WelcomeDoctorPage.aspx");
                    // Response.Write("<script>alert('Correct Patient ID & Password.')</script>");

                }
                else
                {
                    Response.Write("<script>alert('Incorrect Doctor ID or Password.')</script>");
                }
            }
            catch (Exception exx)
            {
                Response.Write("<script>alert('Exception Occured in Doctor Login Page'" + exx.Message + "'')</script>");
            }
        }
    }
}