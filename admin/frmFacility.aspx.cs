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
    public partial class frmFacility : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindFacilityMaster();
            }
        }

        protected void btnAddFacility_Click(object sender, EventArgs e)
        {
            clsFacility objclsFacility = new clsFacility();
            objclsFacility.facilityName = txtFacilityName.Text.ToString();
            objclsFacility.isActive = chkIsActive.Checked;
            objclsFacility.createdBy = Convert.ToInt32(Session["pkLoginID"]);

            clsFacilityBAL objclsFacilityBAL = new clsFacilityBAL();
            objclsFacilityBAL.AddFacilityMaster(objclsFacility);

            BindFacilityMaster();

            ClearControls();
        }
        private void BindFacilityMaster()
        {
            clsFacilityBAL objclsFacilityBAL = new clsFacilityBAL();
            rptFacility.DataSource = objclsFacilityBAL.GetFacilityMaster(-1, -1);
            rptFacility.DataBind();

        }
        private void BindFacilityMaster(int pkFacilityID)
        {
            clsFacilityBAL objclsFacilityBAL = new clsFacilityBAL();
            DataTable dtFacilityMaster = objclsFacilityBAL.GetFacilityMaster(pkFacilityID, -1);
            if (dtFacilityMaster.Rows.Count > 0)
            {

                if (dtFacilityMaster.Rows[0]["pkFacilityID"] != DBNull.Value)
                {
                    if (dtFacilityMaster.Rows[0]["pkFacilityID"].ToString() != string.Empty)
                    {
                        hidpkFacilityID.Value = dtFacilityMaster.Rows[0]["pkFacilityID"].ToString();
                    }
                }
                if (dtFacilityMaster.Rows[0]["facilityName"] != DBNull.Value)
                {
                    if (dtFacilityMaster.Rows[0]["facilityName"].ToString() != string.Empty)
                    {
                        txtFacilityName.Text = dtFacilityMaster.Rows[0]["facilityName"].ToString();
                    }
                }
                if (dtFacilityMaster.Rows[0]["isActive"] != DBNull.Value)
                {
                    if (dtFacilityMaster.Rows[0]["isActive"].ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(dtFacilityMaster.Rows[0]["isActive"]))
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

        protected void rptFacility_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pkFacilityID;
            switch (e.CommandName)
            {

                case ("EditFacilityMaster"):

                    pkFacilityID = Convert.ToInt32(e.CommandArgument);
                    BindFacilityMaster(pkFacilityID);
                    btnAddFacility.Visible = false;
                    btnUpdateFacility.Visible = true;
                    break;

                case ("DisableFacilityMaster"):

                    pkFacilityID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableFacilityMaster(pkFacilityID, false);
                    break;

                case ("EnableFacilityMaster"):

                    pkFacilityID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableFacilityMaster(pkFacilityID, true);
                    break;

            }
        }
        private void EnableDisableFacilityMaster(int pkFacilityID, bool isActive)
        {
            clsFacilityBAL objclsFacilityBAL = new clsFacilityBAL();
            objclsFacilityBAL.EnableDisableFacilityMaster(pkFacilityID, isActive);

            BindFacilityMaster();

        }
        protected void ClearControls()
        {
            txtFacilityName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnUpdateFacility_Click(object sender, EventArgs e)
        {
            clsFacility objclsFacility = new clsFacility();
            objclsFacility.facilityName = txtFacilityName.Text.ToString();
            objclsFacility.isActive = chkIsActive.Checked;

            clsFacilityBAL objclsFacilityBAL = new clsFacilityBAL();
            objclsFacilityBAL.UpdateFacilityMaster(objclsFacility, Convert.ToInt32(hidpkFacilityID.Value));

            BindFacilityMaster();

            ClearControls();

            btnAddFacility.Visible = true;
            btnUpdateFacility.Visible = false;
        }
    }
}