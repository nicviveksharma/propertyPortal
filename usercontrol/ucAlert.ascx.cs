using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PropertyPortal.usercontrol
{
    public partial class ucAlert : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void showAlert(string alertHeader, string alertMessage, string customMessage , [Optional] string css)
        {
            lblAlertHeader.Text = string.Empty;
            lblAlertMessage.Text = string.Empty;
            lblAlertCustom.Text = string.Empty;
            if (alertHeader != string.Empty)
            {
                lblAlertHeader.Text = alertHeader;
            }
            if (alertMessage != string.Empty)
            {
                lblAlertMessage.Text = alertMessage;
                lblAlertMessage.CssClass = css;
                lblAlertCustom.CssClass = css;
            }
            if (customMessage != string.Empty)
            {
                lblAlertCustom.Text = customMessage;
                lblAlertMessage.CssClass = css;
                lblAlertCustom.CssClass = css;
            }
            modalStatus.Show();
        }
    }
}