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
    public partial class ucProperty : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindStateMaster();
                BindDistrictMaster();
                BindCityMaster();
                BindPropertyCategoryMaster();
                BindPropertyTypeMaster();
                BindRentTypeMaster();
                BindFeatureMaster();
                BindFacilityMaster();
                BindUserMaster();
                BindProperty();
            }
        }
        private void BindStateMaster()
        {
            clsStateBAL objclsStateBAL = new clsStateBAL();
            drpState.DataSource = objclsStateBAL.GetStateMaster(-1, 1);
            drpState.DataTextField = "stateName";
            drpState.DataValueField = "pkStateID";
            drpState.DataBind();
            drpState.Items.Insert(0, new ListItem("--Select State--", ""));
        }
        private void BindDistrictMaster()
        {
            if (drpState.SelectedIndex > 0)
            {
                clsDistrictBAL objclsDistrictBAL = new clsDistrictBAL();
                drpDistrict.DataSource = objclsDistrictBAL.GetDistrictMaster(Convert.ToInt32(drpState.SelectedValue), -1, 1);
                drpDistrict.DataTextField = "districtName";
                drpDistrict.DataValueField = "pkDistrictID";
                drpDistrict.DataBind();
                drpDistrict.Items.Insert(0, new ListItem("--Select District--"));
            }
            else
            {
                drpDistrict.Items.Insert(0, new ListItem("--Select District--"));
            }
        }
        private void BindCityMaster()
        {
            if (drpDistrict.SelectedIndex > 0)
            {
                clsCityBAL objclsCityBAL = new clsCityBAL();
                drpCity.DataSource = objclsCityBAL.GetCityMaster(Convert.ToInt32(drpDistrict.SelectedValue), -1, 1);
                drpCity.DataTextField = "cityName";
                drpCity.DataValueField = "pkCityID";
                drpCity.DataBind();
                drpCity.Items.Insert(0, new ListItem("--Select City--"));
            }
            else
            {
                drpCity.Items.Insert(0, new ListItem("--Select City--"));
            }
        }
        private void BindPropertyCategoryMaster()
        {
            clsPropertyCategoryBAL objclsPropertyCategoryBAL = new clsPropertyCategoryBAL();
            drpPropertyCategory.DataSource = objclsPropertyCategoryBAL.GetPropertyCategoryMaster(-1, 1);
            drpPropertyCategory.DataTextField = "propertyCategoryName";
            drpPropertyCategory.DataValueField = "pkPropertyCategoryID";
            drpPropertyCategory.DataBind();
            drpPropertyCategory.Items.Insert(0, new ListItem("--Select Property Category--"));
        }
        private void BindPropertyTypeMaster()
        {
            clsPropertyTypeBAL objclsPropertyTypeBAL = new clsPropertyTypeBAL();
            drpPropertyType.DataSource = objclsPropertyTypeBAL.GetPropertyTypeMaster(-1, 1);
            drpPropertyType.DataTextField = "propertyTypeName";
            drpPropertyType.DataValueField = "pkPropertyTypeID";
            drpPropertyType.DataBind();
            drpPropertyType.Items.Insert(0, new ListItem("--Select Property Type--"));
        }
        private void BindRentTypeMaster()
        {
            clsRentTypeBAL objclsRentTypeBAL = new clsRentTypeBAL();
            drpRentType.DataSource = objclsRentTypeBAL.GetRentTypeMaster(-1, 1);
            drpRentType.DataTextField = "rentTypeName";
            drpRentType.DataValueField = "pkRentTypeID";
            drpRentType.DataBind();
            drpRentType.Items.Insert(0, new ListItem("--Select Rent Type--"));
        }
        private void BindFeatureMaster()
        {
            clsFeatureBAL objclsFeatureBAL = new clsFeatureBAL();
            chkPropertyFeature.DataSource = objclsFeatureBAL.GetFeatureMaster(-1, 1);
            chkPropertyFeature.DataTextField = "featureName";
            chkPropertyFeature.DataValueField = "pkFeatureID";
            chkPropertyFeature.DataBind();
        }
        private void BindFacilityMaster()
        {
            clsFacilityBAL objclsFacilityBAL = new clsFacilityBAL();
            rptFacilities.DataSource = objclsFacilityBAL.GetFacilityMaster(-1, 1);
            rptFacilities.DataBind();
        }
        private void BindUserMaster()
        {
            clsUserBAL objclsUserBAL = new clsUserBAL();
            drpUser.DataSource = objclsUserBAL.GetUserMaster(-1, -1, -1);
            drpUser.DataTextField = "fullName";
            drpUser.DataValueField = "pkUserID";
            drpUser.DataBind();
        }

        private void BindProperty()
        {
            clsPropertyBAL objclsPropertyBAL = new clsPropertyBAL();
            rptProperty.DataSource = objclsPropertyBAL.GetProperty(-1,-1);
            rptProperty.DataBind();
        }

        protected void ClearControls()
        {
            txtPropertyTitle.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnAddProperty_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int pkLoginID = Convert.ToInt32(Session["pkLoginID"]);

                clsProperty objclsProperty = new clsProperty();

                objclsProperty.fkStateID = Convert.ToInt32(drpState.SelectedValue);
                objclsProperty.fkDistrictID = Convert.ToInt32(drpDistrict.SelectedValue);
                objclsProperty.fkCityID = Convert.ToInt32(drpCity.SelectedValue);
                objclsProperty.fkPropertyCategoryID = Convert.ToInt32(drpPropertyCategory.SelectedValue);
                if (drpPropertyCategory.SelectedItem.Text.Contains("Rent"))
                {
                    objclsProperty.fkRentTypeID = Convert.ToInt32(drpRentType.SelectedValue);
                }
                objclsProperty.fkPropertyTypeID = Convert.ToInt32(drpPropertyType.SelectedValue);
                objclsProperty.fkOwnerUserID = pkLoginID;
                objclsProperty.propertyTitle = txtPropertyTitle.Text.Trim();
                objclsProperty.propertyShortTitle = txtPropertyShortTitle.Text.Trim();
                objclsProperty.propertyLink = txtPropertyLink.Text.Trim();
                objclsProperty.propertyShortDescription = txtPropertyShortDescription.Text.Trim();
                objclsProperty.propertyLongDescription = txtPropertyLongDescription.Text.Trim();
                objclsProperty.propertyLatitude = txtPropertyLatitude.Text.Trim();
                objclsProperty.propertyLongitude = txtPropertyLongitude.Text.Trim();
                objclsProperty.propertyAddress = txtPropertyAddress.Text.Trim();
                objclsProperty.propertyTotalFloor = Convert.ToInt32(txtPropertyTotalFloor.Text.Trim());
                objclsProperty.propertyTotalBedroom = Convert.ToInt32(txtPropertyTotalBedroom.Text.Trim());
                objclsProperty.propertyTotalBathroom = Convert.ToInt32(txtPropertyTotalBathroom.Text.Trim());
                objclsProperty.propertyArea = txtPropertyArea.Text.Trim();
                objclsProperty.propertyPrice = Convert.ToDouble(txtPropertyPrice.Text.Trim());
                objclsProperty.propertyYoutubeLink = txtPropertyYoutubeLink.Text.Trim();
                objclsProperty.propertySEOTitle = txtPropertySEOTitle.Text.Trim();
                objclsProperty.propertySEODescription = txtPropertySEODescription.Text.Trim();
                objclsProperty.isFeatured = chkIsFeatured.Checked;
                objclsProperty.isActive = chkIsActive.Checked;
                objclsProperty.isVerified = chkIsActive.Checked;
                objclsProperty.createdBy = pkLoginID;
                objclsProperty.createdOn = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss"));
                objclsProperty.modifiedBy = pkLoginID;
                objclsProperty.modifiedOn = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss"));
                objclsProperty.verifiedBy = pkLoginID;
                objclsProperty.verifiedOn = Convert.ToDateTime(DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss"));

                clsPropertyBAL objclsPropertyBAL = new clsPropertyBAL();

                int fkPropertyID = objclsPropertyBAL.AddProperty(objclsProperty);

                if (fkPropertyID > 0)
                {
                    //Image
                    byte[] uploadedfileinbytes;
                    if (hidimagefile.Value != string.Empty && hidimagefile.Value.Length > 0)
                    {
                        string imagestring = hidimagefile.Value;
                        imagestring = imagestring.Replace("data:image/jpeg;base64,", "");
                        uploadedfileinbytes = Convert.FromBase64String(imagestring);
                        clsPropertyImage objclsPropertyImage = new clsPropertyImage();
                        clsPropertyImageBAL objclsPropertyImageBAL = new clsPropertyImageBAL();
                        objclsPropertyImage.fkPropertyID = fkPropertyID;
                        objclsPropertyImage.propertyImage = uploadedfileinbytes;
                        objclsPropertyImage.isFeaturedImage = chkIsFeatured.Checked;
                        objclsPropertyImage.isBannerImage = false;
                        objclsPropertyImageBAL.AddPropertyImage(objclsPropertyImage);
                    }

                    //Feature

                    foreach (ListItem chkItem in chkPropertyFeature.Items)
                    {
                        if (chkItem.Selected)
                        {
                            clsPropertyFeature objclsPropertyFeature = new clsPropertyFeature();
                            objclsPropertyFeature.fkPropertyID = fkPropertyID;
                            objclsPropertyFeature.fkFeatureID = Convert.ToInt32(chkItem.Value);

                            clsPropertyFeatureBAL objclsPropertyFeatureBAL = new clsPropertyFeatureBAL();
                            objclsPropertyFeatureBAL.AddPropertyFeature(objclsPropertyFeature);

                        }
                    }

                    //Facility
                    foreach (RepeaterItem rptItem in rptFacilities.Items)
                    {
                        Label lblpkFacilityID = (Label)rptItem.FindControl("lblpkFacilityID");
                        TextBox txtFacilityDistance = (TextBox)rptItem.FindControl("txtFacilityDistance");
                        clsPropertyFacility objclsPropertyFacility = new clsPropertyFacility();
                        objclsPropertyFacility.fkPropertyID = fkPropertyID;
                        objclsPropertyFacility.fkFacilityID = Convert.ToInt32(lblpkFacilityID.Text);
                        objclsPropertyFacility.propertyFacilityDistance = Convert.ToDouble(txtFacilityDistance.Text.Trim());

                        clsPropertyFacilityBAL objclsPropertyFacilityBAL = new clsPropertyFacilityBAL();
                        objclsPropertyFacilityBAL.AddPropertyFacility(objclsPropertyFacility);

                    }
                    
                }
                if (fkPropertyID != 0)
                {
                    ucAlert.showAlert("SUCCESS", objclsProperty.propertyTitle + "", "Added Successfully", "fw-bold text-success");
                }
                else if (fkPropertyID == 0)
                {
                    ucAlert.showAlert("WARNING", objclsProperty.propertyTitle + " Already Exists!", "Choose Another PROPERTY Name", "fw-bold text-danger");
                }
            }
        }

        protected void btnUpdateProperty_Click(object sender, EventArgs e)
        {

        }

        protected void drpState_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindDistrictMaster();
            BindCityMaster();
        }

        protected void drpDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindCityMaster();
        }

        protected void drpPropertyCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlPropertyRentType.Visible = false;
            if (drpPropertyCategory.SelectedItem.Text.Contains("Rent"))
            {
                pnlPropertyRentType.Visible = true;
                BindRentTypeMaster();
            }

        }
    }
}