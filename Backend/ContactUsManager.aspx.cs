using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Capstone.App_Code;

namespace Capstone.Backend
{
    public partial class ContactUsManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string strContactID = "";
            int intContactID = 0;

            if ((!IsPostBack) && Request.QueryString["ContactID"] != null)
            {
                strContactID = Request.QueryString["ContactID"].ToString();
                lblContactID.Text = strContactID;

                intContactID = Convert.ToInt32(strContactID);

                contactUs temp = new contactUs();
                SqlDataReader dr = temp.FindCustomer(intContactID);


                while (dr.Read())
                {
                    lblContactName.Text = dr["contactName"].ToString();
                    lblContactMessage.Text = dr["contactMessage"].ToString();
                    lblContactEmail.Text = dr["contactEmail"].ToString();


                }
            }

        }

        protected void btnUpdateContactMsg_Click(object sender, EventArgs e)
        {

            contactUs temp = new contactUs();
            temp.ContactID = Int32.Parse(lblContactID.Text);
          

            //Form
            temp.ContactStatus = txtContactStatus.Text;
            


            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.UpdateARecord();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Backend/ControlPanel");
        }
    }
}