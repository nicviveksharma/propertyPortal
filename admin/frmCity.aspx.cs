using PropertyPortal.BAL;
using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PropertyPortal.admin
{
    public partial class frmCity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDistrictMaster();
                BindCityMaster();
            }
        }

        protected void btnAddCity_Click(object sender, EventArgs e)
        {
            clsCity objclsCity = new clsCity();
            objclsCity.fkDistrictID = Convert.ToInt32(drpDistrict.SelectedValue);
            objclsCity.cityName = txtCityName.Text.ToString();
            objclsCity.isActive = chkIsActive.Checked;
            objclsCity.createdBy = Convert.ToInt32(Session["pkLoginID"]);

            clsCityBAL objclsCityBAL = new clsCityBAL();
            objclsCityBAL.AddCityMaster(objclsCity);

            BindCityMaster();

            ClearControls();
        }

        private void BindDistrictMaster()
        {
            clsDistrictBAL objclsDistrictBAL = new clsDistrictBAL();
            drpDistrict.DataSource = objclsDistrictBAL.GetDistrictMaster(-1, -1, -1);
            drpDistrict.DataTextField = "districtName";
            drpDistrict.DataValueField = "pkDistrictID";
            drpDistrict.DataBind();

        }
        private void BindCityMaster()
        {
            clsCityBAL objclsCityBAL = new clsCityBAL();
            rptCity.DataSource = objclsCityBAL.GetCityMaster(-1, -1, -1);
            rptCity.DataBind();

        }
        private void BindCityMaster(int pkCityID)
        {
            clsCityBAL objclsCityBAL = new clsCityBAL();
            DataTable dtCityMaster = objclsCityBAL.GetCityMaster(-1, pkCityID, -1);
            if (dtCityMaster.Rows.Count > 0)
            {

                if (dtCityMaster.Rows[0]["pkCityID"] != DBNull.Value)
                {
                    if (dtCityMaster.Rows[0]["pkCityID"].ToString() != string.Empty)
                    {
                        hidpkCityID.Value = dtCityMaster.Rows[0]["pkCityID"].ToString();
                    }
                }
                if (dtCityMaster.Rows[0]["cityName"] != DBNull.Value)
                {
                    if (dtCityMaster.Rows[0]["cityName"].ToString() != string.Empty)
                    {
                        txtCityName.Text = dtCityMaster.Rows[0]["cityName"].ToString();
                    }
                }
                if (dtCityMaster.Rows[0]["isActive"] != DBNull.Value)
                {
                    if (dtCityMaster.Rows[0]["isActive"].ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(dtCityMaster.Rows[0]["isActive"]))
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

        protected void rptCity_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pkCityID;
            switch (e.CommandName)
            {

                case ("EditCityMaster"):

                    pkCityID = Convert.ToInt32(e.CommandArgument);
                    BindCityMaster(pkCityID);
                    btnAddCity.Visible = false;
                    btnUpdateCity.Visible = true;
                    break;

                case ("DisableCityMaster"):

                    pkCityID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableCityMaster(pkCityID, false);
                    break;

                case ("EnableCityMaster"):

                    pkCityID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableCityMaster(pkCityID, true);
                    break;

            }
        }
        private void EnableDisableCityMaster(int pkCityID, bool isActive)
        {
            clsCityBAL objclsCityBAL = new clsCityBAL();
            objclsCityBAL.EnableDisableCityMaster(pkCityID, isActive);

            BindCityMaster();

        }
        protected void ClearControls()
        {
            txtCityName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnUpdateCity_Click(object sender, EventArgs e)
        {
            clsCity objclsCity = new clsCity();
            objclsCity.cityName = txtCityName.Text.ToString();
            objclsCity.isActive = chkIsActive.Checked;

            clsCityBAL objclsCityBAL = new clsCityBAL();
            objclsCityBAL.UpdateCityMaster(objclsCity, Convert.ToInt32(hidpkCityID.Value));

            BindCityMaster();

            ClearControls();

            btnAddCity.Visible = true;
            btnUpdateCity.Visible = false;
        }
    }
}