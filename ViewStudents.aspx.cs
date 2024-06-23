using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Advisor
{
    public partial class ViewStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try { 
           string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
           SqlConnection conn = new SqlConnection(connStr);
            SqlCommand viewStudents = new SqlCommand("AdminListStudentsWithAdvisors", conn);
            viewStudents.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataReader rdr = viewStudents.ExecuteReader(CommandBehavior.CloseConnection);
            int advisor_ID = (int)Session["Advisor_ID"];
            int Every_Advisor_ID;
                while (rdr.Read())
                {
                    String studentFName = rdr.GetString(rdr.GetOrdinal("f_name"));
                    String studentLName = rdr.GetString(rdr.GetOrdinal("l_name"));
                    Every_Advisor_ID = rdr.GetInt32(rdr.GetOrdinal("advisor_id"));
                    if (Every_Advisor_ID == advisor_ID)
                    {
                        String studentName = studentFName + studentLName;
                        Label name = new Label();
                        name.Text = studentName;
                        form1.Controls.Add(name);
                    }

                }
                }
            catch (Exception ex)
            {
                Response.Write("error occured");
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}