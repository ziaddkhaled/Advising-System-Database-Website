using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Advisor
{
    public partial class GradPlanInsertion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_button_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection comm = new SqlConnection(connStr);
                int student;
                int creditHours;
                String Semester = semCode.Text;
                String ExpGradDate = gradDate.Text;
                if (string.IsNullOrWhiteSpace(Semester) || string.IsNullOrWhiteSpace(ExpGradDate) || string.IsNullOrWhiteSpace(studentID.Text) || string.IsNullOrWhiteSpace(semCredHours.Text))
                {
                    Response.Write("Please fill in all the required fields.");
                    return;
                }
                int AdvisorId = (int)Session["Advisor_ID"];
                if (int.TryParse(studentID.Text, out student) == false || int.TryParse(semCredHours.Text, out creditHours) == false)
                {
                    Response.Write("Please enter a valid  number.");
                    return;

                }


                student = Int16.Parse(studentID.Text);
                creditHours = Int16.Parse(semCredHours.Text);
                SqlCommand Grad_PlanInsertion = new SqlCommand("Procedures_AdvisorCreateGP", comm);
                comm.Open();
                Grad_PlanInsertion.CommandType = CommandType.StoredProcedure;
                Grad_PlanInsertion.Parameters.Add(new SqlParameter("@Semester_code", Semester));
                Grad_PlanInsertion.Parameters.Add(new SqlParameter("@expected_graduation_date", ExpGradDate));
                Grad_PlanInsertion.Parameters.Add(new SqlParameter("@sem_credit_hours", creditHours));
                Grad_PlanInsertion.Parameters.Add(new SqlParameter("@advisor_id", AdvisorId));
                Grad_PlanInsertion.Parameters.Add(new SqlParameter("@student_id", student));

                Grad_PlanInsertion.ExecuteNonQuery();
                comm.Close();
                Response.Write("inserted succesfully");
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