using PropertyPortal.BAL;
using PropertyPortal.BO;
using PropertyPortal.functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PropertyPortal.usercontrol
{
    public partial class ucUser : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindUser();
            }
        }

        private void BindUser()
        {
            clsUserBAL objclsUserBAL = new clsUserBAL();
            rptUser.DataSource = objclsUserBAL.GetUser(-1, -1, -1);
            rptUser.DataBind();
        }
        protected void btnAddUser_Click(object sender, EventArgs e)
        {
            clsLogin objclsLogin = new clsLogin();
            objclsLogin.loginUsername = txtUserEmailAddress.Text.Trim();
            objclsLogin.loginSalt = clsLoginFunctions.GenerateSalt();
            objclsLogin.loginPassword = clsLoginFunctions.HashPassword(txtLoginPassword.Text.Trim(), objclsLogin.loginSalt);
            objclsLogin.loginRole = Convert.ToInt32(functions.clsCommonFunctions.getConfig("user"));
            objclsLogin.isActive = true;
            objclsLogin.isVerified = true;
            objclsLogin.createdOn = DateTime.Now;

            clsLoginBAL objclsLoginBAL = new clsLoginBAL();

            int pkLoginID = objclsLoginBAL.AddLogin(objclsLogin);

            if (pkLoginID > 0)
            {

                clsUser objclsUser = new clsUser();
                objclsUser.fkLoginID = pkLoginID;
                objclsUser.userFirstName = txtUserFirstName.Text.Trim();
                objclsUser.userMiddleName = txtUserMiddleName.Text.Trim();
                objclsUser.userLastName = txtUserLastName.Text.Trim();
                objclsUser.userEmailAddress = objclsLogin.loginUsername;
                objclsUser.userMobileNo = txtUserMobileNo.Text;
                objclsUser.userCompanyName = txtUserCompanyName.Text;
                objclsUser.userCompanyAddress = txtUserCompanyAddress.Text;

                clsUserBAL objclsUserBAL = new clsUserBAL();
                objclsUserBAL.AddUser(objclsUser);

                ucAlert.showAlert("User Registration", "Congratulations, New User Created!", string.Empty);

            }
            else if (pkLoginID == -1)
            {
                ucAlert.showAlert("User Registration", "Email Already Exists, try another!", string.Empty);
            }
        }

        protected void btnUpdateUser_Click(object sender, EventArgs e)
        {

        }
    }
}