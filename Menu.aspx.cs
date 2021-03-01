using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Capstone.App_Code;


namespace Capstone
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void reviewFlavor_Click(object sender, EventArgs e)
        {
            //Redirect to review page for wing flavor by ID
        }

        protected void wishList_Click(object sender, EventArgs e)
        {
            //Redirect to wishlist of user
        }

        protected void btnMenu_Click(object sender, EventArgs e)
        {
            //Display menu
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