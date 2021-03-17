using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using Capstone.App_Code;




//------------------------------------------------------ NEEDS TO BE CONNECTED TO DATABASE ----------------------------------------------//
namespace Capstone
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();

            Conn.ConnectionString = @"Server=sql.neit.edu\studentsqlserver,4500;Database=SE245_GMartin;User Id=SE245_GMartin;Password=008003563;";

            Conn.Open();

            try 
            {
                SqlCommand Comm = new SqlCommand("select * from userCredentials WHERE userName='" + txtUsername.Text + "' AND userPassword='" + txtPassword.Text + "'", Conn);

                SqlDataReader dr = Comm.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        //Response.Write("<script>alert('Login successful');</script>");
                        Session["user"] = dr.GetValue(3).ToString();
                        Session["fname"] = dr.GetValue(1).ToString();

                        txtUsername.Visible = false;
                        txtUsername.Enabled = false;
                        txtPassword.Visible = false;
                        txtPassword.Enabled = false;
                        lblUsername.Visible = false;
                        lblUsername.Enabled = false;
                        lblPassword.Visible = false;
                        lblPassword.Enabled = false;
                        loginButton.Visible = false;
                        loginButton.Enabled = false;
                        lblFeedback.Text = "Welcome, " + dr.GetValue(1).ToString();
                    }
                }
                else
                {
                    Response.Write("<script>alert('Invalid credentials');</script>");
                }
            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('" + ex.Message + "');</script>");
                //return false;
            }
        }
    }
}