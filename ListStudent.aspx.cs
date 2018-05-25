using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Student
{
    public partial class ListStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K0N3OHE\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_student");

            cmd.Connection = con;
            DataTable dt = new DataTable(); 
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
          
            cmd.ExecuteNonQuery();
            
            adpt.Fill(dt);
            
            gvDetails.DataSource= dt;
            gvDetails.DataBind();
               
        }

        
        protected void gvDetails_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            gvDetails.EditIndex = -1;
            showData();
        }
        public void showData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K0N3OHE\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
            con.Close();
            string str = "select Student_name,[Address],Gender,Emails from tbl_student";
            SqlDataAdapter adpts = new SqlDataAdapter(str, con);
            DataTable dt = new DataTable();

            adpts.Fill(dt);
            gvDetails.DataSource = dt;
            gvDetails.DataBind();
        }

        protected void gvDetails_RowEditing(object sender,  System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //GridViewEditEventArgs
          
            gvDetails.EditIndex = e.NewEditIndex;
            showData();   
        }

        protected void gvDetails_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K0N3OHE\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
           
            con.Open();
            //Finding the controls from Gridview for the row which is going to update  


            TextBox studentName = gvDetails.Rows[e.RowIndex].FindControl("txtStudentName") as TextBox;
            TextBox Address = gvDetails.Rows[e.RowIndex].FindControl("txtAddress") as TextBox;
            TextBox Gender = gvDetails.Rows[e.RowIndex].FindControl("txtGender") as TextBox;
            TextBox email_id = gvDetails.Rows[e.RowIndex].FindControl("txt_email") as TextBox;
            

            //updating the record  
            SqlCommand cmd = new SqlCommand("Update tbl_student set Student_name = '" + studentName.Text + "' ,Address='" + Address.Text + "',Gender='" + Gender.Text + "',email_id='" + email_id.Text + "' where Emails='" +email_id.Text+ "' ", con);
            cmd.ExecuteNonQuery();
            con.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            gvDetails.EditIndex = -1;
            //Call ShowData method for displaying updated data  


            showData();
        }
      

        protected void gvDetails_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }

        protected void gvDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-K0N3OHE\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
           
            con.Open();
            //Finding the controls from Gridview for the row which is going to update  
            //********** Label dept_name = gvDetails.Rows[e.RowIndex].FindControl("lbl_Name") as Label;
            TextBox studentName = gvDetails.Rows[e.RowIndex].FindControl("txtStudentName") as TextBox;
            TextBox Address = gvDetails.Rows[e.RowIndex].FindControl("txtAddress") as TextBox;
            TextBox Gender = gvDetails.Rows[e.RowIndex].FindControl("txtGender") as TextBox;
            TextBox email_id = gvDetails.Rows[e.RowIndex].FindControl("txt_email") as TextBox;


            //updating the record  
            SqlCommand cmd = new SqlCommand("delete from tbl_student where Gender='male'", con);
            cmd.ExecuteNonQuery();
            con.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            // gvDetails.EditIndex = -1;
            //Call ShowData method for displaying updated data  
            showData();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }
        

       
    }
}