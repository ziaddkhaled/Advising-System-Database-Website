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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewAdvStudents_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudents.aspx");
        }

       
        protected void insertGradPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("GradPlanInsertion.aspx");
        }

        protected void addCourseGP_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourseGp.aspx");
        }

        protected void updGradDate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateGradDate.aspx");
        }

        protected void deleteCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteCourseFromGP.aspx");
        }

        protected void viewFromMajor_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudentsFromMajor.aspx");
        }

        protected void viewPending_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewPendingReq.aspx");
        }

        

        protected void ApproveRejectCH_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApproveRejectCHReq.aspx");
        }

        protected void ApproveRejectC_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApproveRejectCReq.aspx");
        }

        protected void viewReq_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewReq.aspx");
        }
    }
}