using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PropertyPortal
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["pkLoginID"] != null)
                {
                    if (Session["loginRole"] != null && Session["loginRole"].ToString() == functions.clsCommonFunctions.getConfig("admin"))
                    {
                        lblUsername.Text = "Welcome " + Session["userFirstName"].ToString();
                    }
                    else
                    {
                        Response.Redirect(ConfigurationManager.AppSettings["loginurl"].ToString());
                    }
                }
                else
                {
                    Response.Redirect(ConfigurationManager.AppSettings["loginurl"].ToString());
                }
            }
        }
    }
}