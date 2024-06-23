using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advisor
{
    public partial class AdvisorRegisteration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Advisor_Register(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection comm = new SqlConnection(connStr);
            String name = AdvisorName.Text;
            String pass = SetPassword.Text;
            String emaill = email.Text;
            String officeNo = office.Text;
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(emaill) || string.IsNullOrWhiteSpace(officeNo))
            {
                Response.Write("please fill all requirments");
                return;
            }
            SqlCommand RegisterProc = new SqlCommand("Procedures_AdvisorRegistration", comm);
            RegisterProc.CommandType = CommandType.StoredProcedure;
            RegisterProc.Parameters.Add(new SqlParameter("@advisor_name", name));
            RegisterProc.Parameters.Add(new SqlParameter("@password", pass));
            RegisterProc.Parameters.Add(new SqlParameter("@email", emaill));
            RegisterProc.Parameters.Add(new SqlParameter("@office", officeNo));
            SqlParameter id = RegisterProc.Parameters.Add("@Advisor_id", SqlDbType.Int);
            id.Direction = ParameterDirection.Output;
            comm.Open();
            RegisterProc.ExecuteNonQuery();
            comm.Close();
            if(id != null)
            {
                Response.Redirect("AdvisorLogin.aspx");
            }
            else
            {
                Response.Write("error in advisor credentials");
            }



        }
    }
}