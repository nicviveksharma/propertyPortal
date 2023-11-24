using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using PropertyPortal.BAL;

namespace PropertyPortal.usercontrol
{
    public partial class ucPropertyAgents : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsPropertyBAL objclsPropertyBAL = new clsPropertyBAL();
                DataTable dt = objclsPropertyBAL.GetPropertyMaster(-1, -1);
                rptPropertyAgents.DataSource = dt;
                rptPropertyAgents.DataBind();
            }
        }
    }
}