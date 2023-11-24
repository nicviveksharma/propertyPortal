using PropertyPortal.BAL;
using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PropertyPortal.usercontrol
{
    public partial class ucAllProperties : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindProperty();
            }
        }

        private void BindProperty()
        {
            clsPropertyBAL objclsPropertyBAL = new clsPropertyBAL();
            rptProperty.DataSource = objclsPropertyBAL.GetPropertyMaster(-1, -1);
            rptProperty.DataBind();
        }
    }
}