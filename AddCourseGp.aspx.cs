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
    public partial class AddCourseGp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void addCourse_Click(object sender, EventArgs e)
        { try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection comm = new SqlConnection(connStr);
                if (student_id.Text == null)
                {
                    Response.Write("enter student id");
                    return;
                }
                if (semester_code.Text == null)
                {
                    Response.Write("enter semester code");
                    return;
                }
                if (course_name.Text == null)
                {
                    Response.Write("enter course name");
                    return;
                }
                int sID;
                String semCode = semester_code.Text;
                String crsName = course_name.Text;
                if (string.IsNullOrWhiteSpace(semCode) || string.IsNullOrWhiteSpace(crsName))
                {
                    Response.Write("Please fill in all the required fields.");
                    return;
                }
                if (int.TryParse(student_id.Text, out sID) == false)
                {
                    Response.Write("Please enter a valid  number.");
                    return;

                }
                sID = Convert.ToInt32(student_id.Text);
                SqlCommand addCourse = new SqlCommand("Procedures_AdvisorAddCourseGP", comm);
                addCourse.CommandType = CommandType.StoredProcedure;
                addCourse.Parameters.Add(new SqlParameter("@student_id", sID));
                addCourse.Parameters.Add(new SqlParameter("@Semester_code", semCode));
                addCourse.Parameters.Add(new SqlParameter("@course_name", crsName));
                comm.Open();
                addCourse.ExecuteNonQuery();
                comm.Close();
                Response.Write("insertion successful");
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