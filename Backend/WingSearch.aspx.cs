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
    public partial class WingSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            //------------------------------------------------------------------- Fill In Dataset -----------------------------------------------------------

            //Create an object
            Ewing temp = new Ewing();

            //Use the object function to fill Dataset object
            DataSet ds = temp.SearchEwing_DS(txtWingName.Text, txtWingDesc.Text);

            dgResults.DataSource = ds;
            dgResults.DataMember = ds.Tables[0].TableName;
            dgResults.DataBind();



        }
    }
}
