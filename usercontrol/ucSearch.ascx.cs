using PropertyPortal.BAL;
using PropertyPortal.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PropertyPortal.usercontrol
{
    public partial class ucSearch : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPropertyCategoryMaster();
                BindPropertyTypeMaster();
                BindCityMaster();
            }
        }

        private void BindPropertyCategoryMaster()
        {
            clsPropertyCategoryBAL objclsPropertyCategoryBAL = new clsPropertyCategoryBAL();
            drpPropertyCategory.DataSource = objclsPropertyCategoryBAL.GetPropertyCategoryMaster(-1, 1);
            drpPropertyCategory.DataTextField = "propertyCategoryName";
            drpPropertyCategory.DataValueField = "pkPropertyCategoryID";
            drpPropertyCategory.DataBind();
            drpPropertyCategory.Items.Insert(0, new ListItem("--Select Category--"));
        }

        private void BindPropertyTypeMaster()
        {
            clsPropertyTypeBAL objclsPropertyTypeBAL = new clsPropertyTypeBAL();
            drpPropertyType.DataSource = objclsPropertyTypeBAL.GetPropertyTypeMaster(-1, 1);
            drpPropertyType.DataTextField = "propertyTypeName";
            drpPropertyType.DataValueField = "pkPropertyTypeID";
            drpPropertyType.DataBind();
            drpPropertyType.Items.Insert(0, new ListItem("--Select Type--"));
        }

        private void BindCityMaster()
        {
                clsCityBAL objclsCityBAL = new clsCityBAL();
                drpCity.DataSource = objclsCityBAL.GetCityMaster(-1, -1, 1);
                drpCity.DataTextField = "cityName";
                drpCity.DataValueField = "pkCityID";
                drpCity.DataBind();
                drpCity.Items.Insert(0, new ListItem("--Select City--"));
            
        }

    }
}