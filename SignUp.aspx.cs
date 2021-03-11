using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Capstone.App_Code;

namespace Capstone
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void signUpButton_Click(object sender, EventArgs e)
        {

            //Create a temp for sign up info
            userCredentials temp = new userCredentials();

            //Fill in temp with info from form
            temp.FirstName = txtFirstName.Text;
            temp.LastName = txtLastName.Text;
            temp.UserName = txtUserName.Text;
            temp.UserEmail = txtEmail.Text;
            temp.UserPassword = txtUserPassword.Text;

            if (temp.Feedback.Contains("ERROR:")) //If an error is posted in the class, display it in feedback 
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                //Display info
                lblFeedback.Text = temp.AddARecord();

            }

 
        }

    }
}