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
    public partial class frmPropertyType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindPropertyTypeMaster();
            }
        }

        protected void btnAddPropertyType_Click(object sender, EventArgs e)
        {
            clsPropertyType objclsPropertyType = new clsPropertyType();
            objclsPropertyType.propertyTypeName = txtPropertyTypeName.Text.ToString();
            objclsPropertyType.isActive = chkIsActive.Checked;
            objclsPropertyType.createdBy = Convert.ToInt32(Session["pkLoginID"]);

            clsPropertyTypeBAL objclsPropertyTypeBAL = new clsPropertyTypeBAL();
            objclsPropertyTypeBAL.AddPropertyTypeMaster(objclsPropertyType);

            BindPropertyTypeMaster();

            ClearControls();
        }
        private void BindPropertyTypeMaster()
        {
            clsPropertyTypeBAL objclsPropertyTypeBAL = new clsPropertyTypeBAL();
            rptPropertyType.DataSource = objclsPropertyTypeBAL.GetPropertyTypeMaster(-1, -1);
            rptPropertyType.DataBind();

        }
        private void BindPropertyTypeMaster(int pkPropertyTypeID)
        {
            clsPropertyTypeBAL objclsPropertyTypeBAL = new clsPropertyTypeBAL();
            DataTable dtPropertyTypeMaster = objclsPropertyTypeBAL.GetPropertyTypeMaster(pkPropertyTypeID, -1);
            if (dtPropertyTypeMaster.Rows.Count > 0)
            {

                if (dtPropertyTypeMaster.Rows[0]["pkPropertyTypeID"] != DBNull.Value)
                {
                    if (dtPropertyTypeMaster.Rows[0]["pkPropertyTypeID"].ToString() != string.Empty)
                    {
                        hidpkPropertyTypeID.Value = dtPropertyTypeMaster.Rows[0]["pkPropertyTypeID"].ToString();
                    }
                }
                if (dtPropertyTypeMaster.Rows[0]["propertyTypeName"] != DBNull.Value)
                {
                    if (dtPropertyTypeMaster.Rows[0]["propertyTypeName"].ToString() != string.Empty)
                    {
                        txtPropertyTypeName.Text = dtPropertyTypeMaster.Rows[0]["propertyTypeName"].ToString();
                    }
                }
                if (dtPropertyTypeMaster.Rows[0]["isActive"] != DBNull.Value)
                {
                    if (dtPropertyTypeMaster.Rows[0]["isActive"].ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(dtPropertyTypeMaster.Rows[0]["isActive"]))
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

        protected void rptPropertyType_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pkPropertyTypeID;
            switch (e.CommandName)
            {

                case ("EditPropertyTypeMaster"):

                    pkPropertyTypeID = Convert.ToInt32(e.CommandArgument);
                    BindPropertyTypeMaster(pkPropertyTypeID);
                    btnAddPropertyType.Visible = false;
                    btnUpdatePropertyType.Visible = true;
                    break;

                case ("DisablePropertyTypeMaster"):

                    pkPropertyTypeID = Convert.ToInt32(e.CommandArgument);
                    EnableDisablePropertyTypeMaster(pkPropertyTypeID, false);
                    break;

                case ("EnablePropertyTypeMaster"):

                    pkPropertyTypeID = Convert.ToInt32(e.CommandArgument);
                    EnableDisablePropertyTypeMaster(pkPropertyTypeID, true);
                    break;

            }
        }
        private void EnableDisablePropertyTypeMaster(int pkPropertyTypeID, bool isActive)
        {
            clsPropertyTypeBAL objclsPropertyTypeBAL = new clsPropertyTypeBAL();
            objclsPropertyTypeBAL.EnableDisablePropertyTypeMaster(pkPropertyTypeID, isActive);

            BindPropertyTypeMaster();

        }
        protected void ClearControls()
        {
            txtPropertyTypeName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnUpdatePropertyType_Click(object sender, EventArgs e)
        {
            clsPropertyType objclsPropertyType = new clsPropertyType();
            objclsPropertyType.propertyTypeName = txtPropertyTypeName.Text.ToString();
            objclsPropertyType.isActive = chkIsActive.Checked;

            clsPropertyTypeBAL objclsPropertyTypeBAL = new clsPropertyTypeBAL();
            objclsPropertyTypeBAL.UpdatePropertyTypeMaster(objclsPropertyType, Convert.ToInt32(hidpkPropertyTypeID.Value));

            BindPropertyTypeMaster();

            ClearControls();

            btnAddPropertyType.Visible = true;
            btnUpdatePropertyType.Visible = false;
        }
    }
}