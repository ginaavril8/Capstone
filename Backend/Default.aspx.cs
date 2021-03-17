using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using Capstone.App_Code;


namespace Capstone.Backend
{
    public partial class Default : System.Web.UI.Page
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
                SqlCommand Comm = new SqlCommand("select * from adminCredentials WHERE adUser='" + txtUsername.Text + "' AND adPassword='" + txtPassword.Text + "'", Conn);

                SqlDataReader dr = Comm.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        //Response.Write("<script>alert('Login successful');</script>");
                        Session["adminname"] = dr.GetValue(1).ToString();

                Session["loginSuccessful"] = "TRUE";
                lblFeedback.Text = "Login successful.";
                Response.Redirect("ControlPanel.aspx");
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

