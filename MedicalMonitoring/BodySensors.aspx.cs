using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO.Ports;
using System.Threading;
using System.Net;
using System.Net.Mail;
using System.Text;
//using RestSharp;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Patient_Health_Monitoring_System
{
    public partial class BodySensors : System.Web.UI.Page
    {
        //private static FileStream fs = new FileStream(@"g:\Patient_readings.txt", FileMode.OpenOrCreate, FileAccess.Write);
        //private static StreamWriter m_streamWriter = new StreamWriter(fs);

        protected void Page_Load(object sender, EventArgs e)
        {
            //Timer1_Tick(Timer1, null);
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            SerialPort port = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
            try
            {                
                port.Open();
                
                string data = port.ReadLine();

                string value1 = data.Substring(5, 2);   // temp value
                string value2 = data.Substring(11, 2);     // heartbeat value
           //     string value3 = null; ;
                                        
                txttemp.Value = value1;
                txtheartbeat.Value = value2;
              //  value3 = LoginPage.passuserid;

//                m_streamWriter.WriteLine("{0} {1} {2}",value3,value1, value2);
              //  m_streamWriter.Flush();

                //String scon = @"datasource=localhost;port=3306;username=root;password=admin;database=iothealthdatabase";
                //MySqlConnection conn = new MySqlConnection(scon);

                //String query = " insert into newsensordata values (@ptntid, @tmp, @hertbt)";    
                //MySqlCommand cmd = new MySqlCommand(query, conn);

                //conn.Open();

                //cmd.Parameters.AddWithValue("@ptntid",LoginPage.passuserid);
                //cmd.Parameters.AddWithValue("@tmp", value1);
                //cmd.Parameters.AddWithValue("@hertbt",value2);
               
                //int r = cmd.ExecuteNonQuery();
                //if (r > 0)
                //{
                //    Response.Write("<script> alert('Details saved.') </script>");
                //}
                //else
                //{
                //    Response.Write("<script> alert('Details not saved.') </script>");
                //}
            }
            catch (Exception exx)
            {
                Response.Write("<script>alert('Exception Occured in Doctor Login Page'" + exx.Message + "'')</script>");

            }
            finally
            {
                port.Close();
            }
        }

		protected void TextBox1_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
