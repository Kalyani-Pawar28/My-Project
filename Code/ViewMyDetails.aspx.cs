using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Patient_Health_Monitoring_System
{
    public partial class ViewMyDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                String useridtxt, frstnametxt, lastnametxt, emailidtxt, brthdatetxt, gendrtxt, citytxt, mobnotxt;
                useridtxt = userid.Value;
                frstnametxt = frstname.Value;
                lastnametxt = lstname.Value;
                emailidtxt = email.Value;
                brthdatetxt = brtdate.Value;
                gendrtxt = gen.Value;
                citytxt = city.Value;
                mobnotxt = mno.Value;
                String scon = @"datasource=localhost;port=3306;username=root;password=admin;database=iothealthdatabase";
                MySqlConnection conn = new MySqlConnection(scon);
                String qr = "select * from PatientRegister where Patient_Id= '" + LoginPage.passuserid + "' ";
                MySqlCommand cmnd = new MySqlCommand(qr, conn);
                conn.Open();
                MySqlDataReader rdr = cmnd.ExecuteReader();
                if (rdr.Read())
                {
                    userid.Value = rdr["Patient_Id"].ToString();
                    frstname.Value = rdr["FirstName"].ToString();
                    lstname.Value = rdr["LastName"].ToString();
                    email.Value = rdr["Email"].ToString();
                    brtdate.Value = rdr["DOB"].ToString();
                    gen.Value = rdr["Gender"].ToString();
                    city.Value = rdr["Address"].ToString();
                    mno.Value = rdr["Mobile_No"].ToString();
                }
            }
            catch (Exception exc)
            {
                Response.Write("<script>alert('Exception Occured in Login Page'" + exc.Message + "'')</script>");
            }
        }
    }
}