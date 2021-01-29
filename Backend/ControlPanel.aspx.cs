using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Capstone.Backend
{
    public partial class ControlPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //If user is already logged in, keep them there
            if (Session["loginSuccessful"] != null && Session["loginSuccessful"].ToString() == "TRUE")
            {
                //If true, stay; no redirect
            }
            else
            {
                //If not logged in, redirect to login page/backend
                Response.Redirect("~/Backend/Default.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon(); //Distroy any session vars from this session
            Response.Redirect("~/Backend/Default.aspx"); //Redirect to login
        }
    }
}