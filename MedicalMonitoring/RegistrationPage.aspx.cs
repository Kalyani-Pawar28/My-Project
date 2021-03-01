using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Patient_Health_Monitoring_System
{
    public partial class RegistrationPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ------ To fetch USer ID in text box of PatientID on Form ---------//
            string txt_user_id = user_id.Value;
            int counter = 0;
            String scon = @"datasource=localhost;port=3306;username=root;password=admin;database=iothealthdatabase";
            string Query = "select Patient_ID from PatientRegister";
            MySqlConnection conn = new MySqlConnection(scon);
            MySqlCommand cmnd = new MySqlCommand(Query, conn);
           
            MySqlDataReader rdr;
            conn.Open();
            rdr = cmnd.ExecuteReader();
            while (rdr.Read())
            {
                counter = int.Parse(rdr[0].ToString());
            }
            counter++;
            user_id.Value = counter.ToString();
            rdr.Close();
            conn.Close();
            btnRegister.ServerClick += new EventHandler(btnRegister_Click); 
        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string txt_pass, txt_fname, txt_lname, txt_email,txt_brthdate, txt_genM, txt_genF, txt_city, txt_mno ;
            txt_pass = password.Value;
            txt_fname = fname.Value;
            txt_lname = lname.Value;
            txt_email = email.Value;
            txt_brthdate = dob.Value;
            txt_genM = male.Value;
            txt_genF = female.Value;
            txt_city = city.Value;
            txt_mno = mno.Value;
            try
            {               
                String scon = @"datasource=localhost;port=3306;username=root;password=admin;database=iothealthdatabase";
                MySqlConnection conn = new MySqlConnection(scon);
              
                String query = "insert into patientregister(Password,FirstName,LastName,Email,DOB,Gender,Address,Mobile_No) values (@pass, @fname, @lname , @email,@dobxx, @gen, @city, @mob)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@pass", txt_pass.ToString());
                cmd.Parameters.AddWithValue("@fname", txt_fname.ToString());
                cmd.Parameters.AddWithValue("@lname", txt_lname.ToString());
                cmd.Parameters.AddWithValue("@email", txt_email.ToString());
                cmd.Parameters.AddWithValue("@dobxx", txt_brthdate.ToString());
              
                if (male.Checked == true)
                {
                    cmd.Parameters.AddWithValue("@gen", txt_genM.ToString());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@gen", txt_genF.ToString());
                }
                cmd.Parameters.AddWithValue("@city", txt_city.ToString());
                cmd.Parameters.AddWithValue("@mob", txt_mno.ToString());
               
                conn.Open();
                int r = cmd.ExecuteNonQuery();
                
                if (r > 0)
                {
                    Response.Write("<script> alert('Registeration Successful.') </script>");
                    Response.Redirect("HomePage.aspx");
                }
                else
                {
                    Response.Write("<script> alert('Registration Failed') </script>");
                }
                conn.Close();
            }
            catch (Exception exx)
            {
                Response.Write(exx);
            }
        }
    }
}