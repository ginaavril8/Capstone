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
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnContact_Click(object sender, EventArgs e)
        {
            //Create a temp for contact message
            contactUs temp = new contactUs();

            //Fill in temp with info from form
            temp.ContactName = txtContactName.Text;
            temp.ContactEmail = txtContactEmail.Text;
            temp.ContactMessage = txtContactMessage.Text; 

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