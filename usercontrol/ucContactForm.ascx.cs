using PropertyPortal.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PropertyPortal.BO;

namespace PropertyPortal.usercontrol
{
    public partial class ucContactForm : System.Web.UI.UserControl
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            cptCaptcha.ValidateCaptcha(txtcaptcha.Text.Trim());
            if (cptCaptcha.UserValidated)
            {
                clsContactForm objclsContactForm = new clsContactForm();
                objclsContactForm.name = txtName.Text;
                objclsContactForm.email = txtEmail.Text;
                objclsContactForm.phone = txtMobile.Text;
                objclsContactForm.address = txtAdress.Text;
                objclsContactForm.message = txtMessage.Text;
                objclsContactForm.ip = Convert.ToInt32(functions.clsCommonFunctions.GetIpValue());
                clsContactFormBAL objclsContactFormBAL = new clsContactFormBAL();

                int i = objclsContactFormBAL.AddContactForm(objclsContactForm);
                if (i > 0)
                {
                    ucAlert.showAlert("SUCCESS", "Message", "Sent Successfully", "fw-bold text-success");
                }
            }
        }
    }
}