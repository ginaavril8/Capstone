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
    public partial class WingManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            //If user is already signed in, stay on page 

            if (Session["loginSuccessful"] != null && Session["loginSuccessful"].ToString() == "TRUE")
            {
                //Stay here
            }
            else
            {
                //Redirect to login page
                Response.Redirect("~/Backend/Default.aspx");
            }

            //------------------------------------------------------------------- Check for Existing ID -----------------------------------------------------------

            string strWingID = "";
            int intWingID = 0;

            if ((!IsPostBack) && Request.QueryString["EwingID"] != null)
            {
                strWingID = Request.QueryString["EwingID"].ToString();
                lblWingID.Text = strWingID;

                intWingID = Convert.ToInt32(strWingID);

                Ewing temp = new Ewing();
                SqlDataReader dr = temp.FindOneWing(intWingID);


                while (dr.Read())
                {
                    txtWingName.Text = dr["wingName"].ToString();
                    txtWingFlavor.Text = dr["wingFlavor"].ToString();
                    txtWingDesc.Text = dr["wingDesc"].ToString();


                }
            }

            /*   if (Request.QueryString["wingID"] != null)
               {
                   btnAdd.Visible = false;
                   btnAdd.Enabled = false;
                   //btnDelete.Visible = false;
                   //btnDelete.Enabled = false;
                   btnUpdate.Visible = false;
                   btnUpdate.Enabled = false;
               }
               else
               {

                   btnDelete.Visible = false;
                   btnUpdate.Enabled = false;

               }

           }
            */
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //Create a temp wing item and run constructor
            Ewing temp = new Ewing();

            //Fill in temp with info from form
            temp.WingName = txtWingName.Text;
            temp.WingDesc = txtWingDesc.Text;
            temp.WingFlavor = txtWingFlavor.Text;




            if (temp.Feedback.Contains("ERROR:")) //If an error is posted in the class, display it in feedback 
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                //Display info
                lblFeedback.Text = temp.AddARecord();
                //temp.Title + " by " + temp.AuthorFirst + " " + temp.AuthorLast;

            }
        }



        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Ewing temp = new Ewing();
            temp.EwingID = Int32.Parse(lblWingID.Text);
            //temp.WingName = txtWingName.Text;

            //Form
            temp.WingName = txtWingName.Text;
            temp.WingDesc = txtWingDesc.Text;
            temp.WingFlavor = txtWingFlavor.Text;


            if (temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.Feedback;
            }
            else
            {
                lblFeedback.Text = temp.UpdateARecord();
            }

        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 intWingID = Convert.ToInt32(lblWingID.Text);

            Ewing temp = new Ewing();

            lblFeedback.Text = temp.DeleteOneWing(intWingID);
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Backend/ControlPanel");

        }
    }
} 