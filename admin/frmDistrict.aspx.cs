using PropertyPortal.BAL;
using PropertyPortal.BO;
using PropertyPortal.DAL;
using PropertyPortal.usercontrol;
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
    public partial class frmDistrict : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindStateMaster();
                BindDistrictMaster();
            }
        }

        protected void btnAddDistrict_Click(object sender, EventArgs e)
        {
            clsDistrict objclsDistrict = new clsDistrict();
            objclsDistrict.fkStateID = Convert.ToInt32(drpState.SelectedValue);
            objclsDistrict.districtName = txtDistrictName.Text.ToString();
            objclsDistrict.isActive = chkIsActive.Checked;
            objclsDistrict.createdBy = Convert.ToInt32(Session["pkLoginID"]);

            clsDistrictBAL objclsDistrictBAL = new clsDistrictBAL();
            int id = objclsDistrictBAL.AddDistrictMaster(objclsDistrict);

            if (id == 0)
            {
                modaldistrict.Show();
                btnAddDistrict.Visible = true;
                btnUpdateDistrict.Visible = false;
                ucAlert.showAlert("WARNING", objclsDistrict.districtName + " Already Exists!", "Choose Another District Name", "fw-bold text-danger");
            }
            else if (id > 0)
            {
                BindDistrictMaster();
                ClearControls();
                btnAddDistrict.Visible = true;
                btnUpdateDistrict.Visible = false;
                drpState.Enabled = true;
                ucAlert.showAlert("SUCCESS", objclsDistrict.districtName + "", "Added Successfully", "fw-bold text-success");
            }
        }

        private void BindStateMaster()
        {
            clsStateBAL objclsStateBAL = new clsStateBAL();
            drpState.DataSource = objclsStateBAL.GetStateMaster(-1, -1);
            drpState.DataTextField = "stateName";
            drpState.DataValueField = "pkStateID";
            drpState.DataBind();

        }
        private void BindDistrictMaster()
        {
            clsDistrictBAL objclsDistrictBAL = new clsDistrictBAL();
            rptDistrict.DataSource = objclsDistrictBAL.GetDistrictMaster(-1, -1, -1);
            rptDistrict.DataBind();
        }
        private void BindDistrictMaster(int pkDistrictID)
        {
            clsDistrictBAL objclsDistrictBAL = new clsDistrictBAL();
            DataTable dtDistrictMaster = objclsDistrictBAL.GetDistrictMaster(-1, pkDistrictID, -1);
            if (dtDistrictMaster.Rows.Count > 0)
            {

                if (dtDistrictMaster.Rows[0]["pkDistrictID"] != DBNull.Value)
                {
                    if (dtDistrictMaster.Rows[0]["pkDistrictID"].ToString() != string.Empty)
                    {
                        hidpkDistrictID.Value = dtDistrictMaster.Rows[0]["pkDistrictID"].ToString();
                    }
                }
                if (dtDistrictMaster.Rows[0]["districtName"] != DBNull.Value)
                {
                    if (dtDistrictMaster.Rows[0]["districtName"].ToString() != string.Empty)
                    {
                        txtDistrictName.Text = dtDistrictMaster.Rows[0]["districtName"].ToString();
                    }
                }
                if (dtDistrictMaster.Rows[0]["isActive"] != DBNull.Value)
                {
                    if (dtDistrictMaster.Rows[0]["isActive"].ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(dtDistrictMaster.Rows[0]["isActive"]))
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

        protected void rptDistrict_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pkDistrictID;
            switch (e.CommandName)
            {

                case ("EditDistrictMaster"):

                    modaldistrict.Show();
                    pkDistrictID = Convert.ToInt32(e.CommandArgument);
                    BindDistrictMaster(pkDistrictID);
                    drpState.Enabled = false;
                    btnAddDistrict.Visible = false;
                    btnUpdateDistrict.Visible = true;
                    break;

                case ("DisableDistrictMaster"):

                    pkDistrictID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableDistrictMaster(pkDistrictID, false);
                    break;

                case ("EnableDistrictMaster"):

                    pkDistrictID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableDistrictMaster(pkDistrictID, true);
                    break;

            }
        }
        private void EnableDisableDistrictMaster(int pkDistrictID, bool isActive)
        {
            clsDistrictBAL objclsDistrictBAL = new clsDistrictBAL();
            objclsDistrictBAL.EnableDisableDistrictMaster(pkDistrictID, isActive);

            BindDistrictMaster();

        }
        protected void ClearControls()
        {
            txtDistrictName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnUpdateDistrict_Click(object sender, EventArgs e)
        {
            clsDistrict objclsDistrict = new clsDistrict();
            objclsDistrict.districtName = txtDistrictName.Text.ToString();
            objclsDistrict.isActive = chkIsActive.Checked;
            objclsDistrict.fkStateID = Convert.ToInt32(drpState.SelectedValue);
            clsDistrictBAL objclsDistrictBAL = new clsDistrictBAL();


            int id = objclsDistrictBAL.UpdateDistrictMaster(objclsDistrict, Convert.ToInt32(hidpkDistrictID.Value));

            if (id == 0)
            {
                modaldistrict.Show();
                BindDistrictMaster(Convert.ToInt32(hidpkDistrictID.Value));
                btnAddDistrict.Visible = false;
                btnUpdateDistrict.Visible = true;
                ucAlert.showAlert("WARNING", objclsDistrict.districtName + " Already Exists!", "Choose Another State Name", "fw-bold text-danger");
            }
            else if (id > 0)
            {
                BindDistrictMaster();
                ClearControls();
                btnAddDistrict.Visible = true;
                btnUpdateDistrict.Visible = false;
                drpState.Enabled = true;
                ucAlert.showAlert("SUCCESS", objclsDistrict.districtName + "", "Updated Successfully", "fw-bold text-success");
            }
        }

        protected void btnClosedistrict_Click(object sender, EventArgs e)
        {
            ClearControls();
            btnAddDistrict.Visible = true;
            btnUpdateDistrict.Visible = false;
            modaldistrict.Hide();
        }
    }
}