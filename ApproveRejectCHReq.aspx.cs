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
    public partial class ApproveRejectCHReq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void execute_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                string semCode = semester_code.Text;
                if (string.IsNullOrWhiteSpace(semCode) || string.IsNullOrWhiteSpace(rId.Text))
                {
                    Response.Write("Please fill in all the required fields.");
                    return;
                }
                int reqID;
                if (int.TryParse(rId.Text, out reqID) == false)
                {
                    Response.Write("Please enter a valid  number.");
                    return;

                }
                reqID = Int32.Parse(rId.Text);
                SqlCommand AppRej = new SqlCommand("Procedures_AdvisorApproveRejectCHRequest", conn);
                AppRej.CommandType = CommandType.StoredProcedure;
                AppRej.Parameters.Add(new SqlParameter("@requestID", reqID));
                AppRej.Parameters.Add(new SqlParameter("@current_sem_code", semCode));
                conn.Open();
                AppRej.ExecuteNonQuery();
                conn.Close();
                Response.Write("request updated");
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