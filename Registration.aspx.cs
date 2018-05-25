using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;


namespace Student
{
    public partial class Registration : System.Web.UI.Page
    {
        string gender;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Selecting Gender
            if (rbtMale.Checked)
            {
                    gender ="M";
            }
            else
            {
                gender = "F";
            }
            //Create connection
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K0N3OHE\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_student values('" + txtName.Text + "','" + txtAddress.Text + "','" + gender + "','" + txtMail.Text + "','"+txtPhone.Text+"')");
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            //display Message
            string displayMessage = "Student Details Registered successfully";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + displayMessage + "');", true);
            reset();
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            //Redirct Page to List Student
            Response.Redirect("ListStudent.aspx");

        }
        //Create Function for Clear All Values in textboxes
        public void reset()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
        }

        protected void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}