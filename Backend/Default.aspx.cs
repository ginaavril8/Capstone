using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
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
            if (txtUsername.Text == "Capstone" && txtPassword.Text == "NEIT")
            {
                //If both entries are a match, set sessions so that other pages know that they are logged in
                Session["userName"] = txtUsername.Text;
                Session["loginSuccessful"] = "TRUE";
                lblFeedback.Text = "Login successful.";
                Response.Redirect("ControlPanel.aspx");
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