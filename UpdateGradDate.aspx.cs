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
    public partial class UpdateGradDate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UpdateDate_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection comm = new SqlConnection(connStr);
                if (string.IsNullOrWhiteSpace(sID.Text) || string.IsNullOrWhiteSpace(expGradDate.Text))
                {
                    Response.Write("please fill the requirments");
                    return;
                }
                String expgradDate = expGradDate.Text;
                int student_id = Convert.ToInt32(sID.Text);
                SqlCommand updateGP = new SqlCommand("Procedures_AdvisorUpdateGP", comm);
                updateGP.CommandType = CommandType.StoredProcedure;
                updateGP.Parameters.Add(new SqlParameter("@expected_grad_date", expgradDate));
                updateGP.Parameters.Add(new SqlParameter("@studentID", student_id));
                comm.Open();
                updateGP.ExecuteNonQuery();
                comm.Close();
                Response.Write("updated successfully");
            }
            catch (Exception ex)
            {
                Response.Write("error occured");

            }
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}