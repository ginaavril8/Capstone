using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
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

            if (txtUsername.Text == "User" && txtPassword.Text == "Login")
            {
                //If both entries are a match, set sessions so that other pages know that they are logged in
                Session["userName"] = txtUsername.Text;
                Session["loginSuccessful"] = "TRUE";
                lblFeedback.Text = "Login successful.";
            }
            else
            {
                //Else, show try again message
                Session["userName"] = "";
                Session["loginSuccessful"] = "FALSE";
                lblFeedback.Text = "Login unsuccessful. Please try again.";
            }
        }
    }
}