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
    public partial class ViewStudentsFromMajor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

        }

        

        protected void viewClick(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                if (string.IsNullOrWhiteSpace(major.Text))
                {
                    Response.Write("enter major");
                    return;
                }
                int advID = (int)Session["Advisor_ID"];
                string maj = major.Text;
                SqlCommand viewSFromMajor = new SqlCommand("Procedures_AdvisorViewAssignedStudents", conn);
                viewSFromMajor.CommandType = CommandType.StoredProcedure;
                viewSFromMajor.Parameters.Add(new SqlParameter("@AdvisorID", advID));
                viewSFromMajor.Parameters.Add(new SqlParameter("@major", maj));
                conn.Open();
                SqlDataReader rdr = viewSFromMajor.ExecuteReader(CommandBehavior.CloseConnection);
                while (rdr.Read())
                {
                    int student_id = rdr.GetInt32(rdr.GetOrdinal("student_id"));
                    String name = rdr.GetString(rdr.GetOrdinal("Student_name"));
                    string majorr = rdr.GetString(rdr.GetOrdinal("major"));
                    string course_name = rdr.GetString(rdr.GetOrdinal("Course_name"));
                    string result = $"student id:{student_id.ToString()} ,name: {name} ,major: {majorr} ,course name:{course_name}";
                    Label details = new Label();
                    details.Text = result;
                    form1.Controls.Add(details);
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