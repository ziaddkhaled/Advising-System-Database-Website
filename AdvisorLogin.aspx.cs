using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advisor
{
    public partial class AdvisorLogin : System.Web.UI.Page
    {    
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void logIn_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection comm = new SqlConnection(connStr);
            String pass = password.Text;
            if (string.IsNullOrWhiteSpace(pass))
            {
                Response.Write("Please fill in all the required fields.");
                return;
            }
            int id;
            if (int.TryParse(advisorID.Text, out id) == false)
            {
                Response.Write("Please enter a valid  number.");
                return;

            }
            id = Int16.Parse(advisorID.Text);
            SqlCommand AdvisorLoginFn = new SqlCommand("FN_AdvisorLogin", comm);
            AdvisorLoginFn.CommandText = "SELECT dbo.FN_AdvisorLogin(@id, @pass)";
            AdvisorLoginFn.Parameters.AddWithValue("@id", id);
            AdvisorLoginFn.Parameters.AddWithValue("@pass", pass);
            comm.Open();
            bool result = (bool)AdvisorLoginFn.ExecuteScalar();
            comm.Close();
            if (!result)
                Response.Write("Wrong ID or Password");
            if (result)
            {
                Session["Advisor_ID"] = id;
                Response.Redirect("HomePage.aspx");
            }
        }

        protected void signIn(object sender, EventArgs e)
        {
            Response.Redirect("AdvisorRegisteration.aspx");
        }

        
    }
}