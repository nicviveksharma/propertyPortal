using PropertyPortal.BAL;
using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PropertyPortal.admin
{
    public partial class frmPropertyCategory : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPropertyCategoryMaster();
            }
        }

        protected void btnAddPropertyCategory_Click(object sender, EventArgs e)
        {
            clsPropertyCategory objclsPropertyCategory = new clsPropertyCategory();
            objclsPropertyCategory.propertyCategoryName = txtPropertyCategoryName.Text.ToString();
            objclsPropertyCategory.isActive = chkIsActive.Checked;
            objclsPropertyCategory.createdBy = Convert.ToInt32(Session["pkLoginID"]);

            clsPropertyCategoryBAL objclsPropertyCategoryBAL = new clsPropertyCategoryBAL();
            objclsPropertyCategoryBAL.AddPropertyCategoryMaster(objclsPropertyCategory);

            BindPropertyCategoryMaster();

            ClearControls();
        }
        private void BindPropertyCategoryMaster()
        {
            clsPropertyCategoryBAL objclsPropertyCategoryBAL = new clsPropertyCategoryBAL();
            rptPropertyCategory.DataSource = objclsPropertyCategoryBAL.GetPropertyCategoryMaster(-1, -1);
            rptPropertyCategory.DataBind();

        }
        private void BindPropertyCategoryMaster(int pkPropertyCategoryID)
        {
            clsPropertyCategoryBAL objclsPropertyCategoryBAL = new clsPropertyCategoryBAL();
            DataTable dtPropertyCategoryMaster = objclsPropertyCategoryBAL.GetPropertyCategoryMaster(pkPropertyCategoryID, -1);
            if (dtPropertyCategoryMaster.Rows.Count > 0)
            {

                if (dtPropertyCategoryMaster.Rows[0]["pkPropertyCategoryID"] != DBNull.Value)
                {
                    if (dtPropertyCategoryMaster.Rows[0]["pkPropertyCategoryID"].ToString() != string.Empty)
                    {
                        hidpkPropertyCategoryID.Value = dtPropertyCategoryMaster.Rows[0]["pkPropertyCategoryID"].ToString();
                    }
                }
                if (dtPropertyCategoryMaster.Rows[0]["propertyCategoryName"] != DBNull.Value)
                {
                    if (dtPropertyCategoryMaster.Rows[0]["propertyCategoryName"].ToString() != string.Empty)
                    {
                        txtPropertyCategoryName.Text = dtPropertyCategoryMaster.Rows[0]["propertyCategoryName"].ToString();
                    }
                }
                if (dtPropertyCategoryMaster.Rows[0]["isActive"] != DBNull.Value)
                {
                    if (dtPropertyCategoryMaster.Rows[0]["isActive"].ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(dtPropertyCategoryMaster.Rows[0]["isActive"]))
                        {
                            chkIsActive.Checked = true;
                        }
                        else
                        {
                            chkIsActive.Checked = false;
                        }
                    }
                }
            }
        }

        protected void rptPropertyCategory_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pkPropertyCategoryID;
            switch (e.CommandName)
            {

                case ("EditPropertyCategoryMaster"):

                    pkPropertyCategoryID = Convert.ToInt32(e.CommandArgument);
                    BindPropertyCategoryMaster(pkPropertyCategoryID);
                    btnAddPropertyCategory.Visible = false;
                    btnUpdatePropertyCategory.Visible = true;
                    break;

                case ("DisablePropertyCategoryMaster"):

                    pkPropertyCategoryID = Convert.ToInt32(e.CommandArgument);
                    EnableDisablePropertyCategoryMaster(pkPropertyCategoryID, false);
                    break;

                case ("EnablePropertyCategoryMaster"):

                    pkPropertyCategoryID = Convert.ToInt32(e.CommandArgument);
                    EnableDisablePropertyCategoryMaster(pkPropertyCategoryID, true);
                    break;

            }
        }
        private void EnableDisablePropertyCategoryMaster(int pkPropertyCategoryID, bool isActive)
        {
            clsPropertyCategoryBAL objclsPropertyCategoryBAL = new clsPropertyCategoryBAL();
            objclsPropertyCategoryBAL.EnableDisablePropertyCategoryMaster(pkPropertyCategoryID, isActive);

            BindPropertyCategoryMaster();

        }
        protected void ClearControls()
        {
            txtPropertyCategoryName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnUpdatePropertyCategory_Click(object sender, EventArgs e)
        {
            clsPropertyCategory objclsPropertyCategory = new clsPropertyCategory();
            objclsPropertyCategory.propertyCategoryName = txtPropertyCategoryName.Text.ToString();
            objclsPropertyCategory.isActive = chkIsActive.Checked;

            clsPropertyCategoryBAL objclsPropertyCategoryBAL = new clsPropertyCategoryBAL();
            objclsPropertyCategoryBAL.UpdatePropertyCategoryMaster(objclsPropertyCategory, Convert.ToInt32(hidpkPropertyCategoryID.Value));

            BindPropertyCategoryMaster();

            ClearControls();

            btnAddPropertyCategory.Visible = true;
            btnUpdatePropertyCategory.Visible = false;
        }
    }
}