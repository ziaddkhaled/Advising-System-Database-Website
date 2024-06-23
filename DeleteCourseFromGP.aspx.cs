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
    public partial class DeleteCourseFromGP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void deleteCourse_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection comm = new SqlConnection(connStr);
                int studentID;
                int courseID;
                String semCode = semester_code.Text;
                if (string.IsNullOrWhiteSpace(semCode) || string.IsNullOrWhiteSpace(student_id.Text) || string.IsNullOrWhiteSpace(course_id.Text))
                {
                    Response.Write("please enter semester code");
                    return;

                }
                if ((int.TryParse(student_id.Text, out studentID) == false) || int.TryParse(course_id.Text, out courseID) == false)
                {
                    Response.Write("Please enter a valid  number.");
                    return;

                }


                studentID = Convert.ToInt32(student_id.Text);
                courseID = Convert.ToInt32(course_id.Text);
                SqlCommand deleteCoursee = new SqlCommand("Procedures_AdvisorDeleteFromGP", comm);
                deleteCoursee.CommandType = CommandType.StoredProcedure;
                deleteCoursee.Parameters.Add(new SqlParameter("@studentID", studentID));
                deleteCoursee.Parameters.Add(new SqlParameter("@sem_code", semCode));
                deleteCoursee.Parameters.Add(new SqlParameter("@courseID", courseID));
                comm.Open();
                deleteCoursee.ExecuteNonQuery();
                comm.Close();
                Response.Write("delete complete");
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