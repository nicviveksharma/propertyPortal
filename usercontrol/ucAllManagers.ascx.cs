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
    public partial class ucAllManagers : System.Web.UI.UserControl
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
            rptUser.DataSource = objclsUserBAL.GetUser(-1, 2, -1, -1);
            rptUser.DataBind();
        }
    }
}