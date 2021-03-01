using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace Patient_Health_Monitoring_System
{
    public partial class ViewPatientDetails : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            btnClickhere.ServerClick += new EventHandler(btnClickhere_Click); 
        }
        protected void btnClickhere_Click(object sender, EventArgs e)
        {
            try
            {
                String pnnt=txtPtntID.Value;
                string scon = @"datasource=localhost;port=3306;username=root;password=admin;database=iothealthdatabase";
                string qry = "select FirstName,LastName,Email,DOB,Address,Mobile_No from patientregister where patient_id=@ptntid";
                MySqlConnection conn = new MySqlConnection(scon);
                MySqlCommand cmd = new MySqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@ptntid",pnnt.ToString());
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = cmd;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                gvPatntDetls.DataSource = dTable;
                gvPatntDetls.DataBind();
            }
            catch (Exception exx)
            {
                Response.Write("<script> Exception occured  </script>");
            }
        }
    }
}