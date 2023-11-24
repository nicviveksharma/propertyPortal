using System;
using System.Configuration;

namespace PropertyPortal
{
    public partial class logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Clear the user's session
            Session.Clear();

            // Redirect to the login page 
            Response.Redirect(ConfigurationManager.AppSettings["siteurl"].ToString() + "login.aspx");
        }

    }
}