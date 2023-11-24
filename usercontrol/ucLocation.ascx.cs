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
    public partial class ucLocation : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                clsPropertyImageBAL objclsPropertyImageBAL = new clsPropertyImageBAL();
                DataTable dtimg = new DataTable();
                dtimg =objclsPropertyImageBAL.GetPropertyImage(-1,-1);
                rptLocation.DataSource = dtimg;
                rptLocation.DataBind();

            }
        }
    }
}