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
    public partial class ViewReq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection conn = new SqlConnection(connStr);
            int advisor_id = (int)Session["Advisor_ID"];
            SqlCommand viewReq = new SqlCommand("FN_Advisors_Requests", conn);
            viewReq.CommandText = "SELECT * from dbo.FN_Advisors_Requests(@advisor_id)";
            viewReq.Parameters.AddWithValue("@advisor_id", advisor_id);
            conn.Open();
            SqlDataReader rdr = viewReq.ExecuteReader(CommandBehavior.CloseConnection);
            while (rdr.Read())
            {
                int reqID = rdr.GetInt32(rdr.GetOrdinal("request_id"));
                string type = rdr.GetString(rdr.GetOrdinal("type"));
                string comm = rdr.GetString(rdr.GetOrdinal("comment"));
                string stat = rdr.GetString(rdr.GetOrdinal("status"));
                int credit_hours = rdr.IsDBNull(rdr.GetOrdinal("credit_hours")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("credit_hours"));
                int course_id = rdr.IsDBNull(rdr.GetOrdinal("course_id")) ? 0 : rdr.GetInt32(rdr.GetOrdinal("course_id"));
                int student_id = rdr.GetInt32(rdr.GetOrdinal("student_id"));
                int advisor_IDD = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                string result = $"request id: {reqID.ToString()} type:{type} comment: {comm} status: {stat} credit hours: {credit_hours} course id:{course_id} student id:{student_id} adv id:{advisor_IDD}";
                Label res = new Label();
                res.Text = result;
                form1.Controls.Add(res);
            }
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