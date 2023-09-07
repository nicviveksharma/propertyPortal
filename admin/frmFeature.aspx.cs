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
    public partial class frmFeature : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindFeatureMaster();
            }
        }

        protected void btnAddFeature_Click(object sender, EventArgs e)
        {
            clsFeature objclsFeature = new clsFeature();
            objclsFeature.featureName = txtFeatureName.Text.ToString();
            objclsFeature.isActive = chkIsActive.Checked;
            objclsFeature.createdBy = Convert.ToInt32(Session["pkLoginID"]);

            clsFeatureBAL objclsFeatureBAL = new clsFeatureBAL();


            int id = objclsFeatureBAL.AddFeatureMaster(objclsFeature);

            if (id == 0)
            {
                btnAddFeature.Visible = true;
                btnUpdateFeature.Visible = false;
                BindFeatureMaster();
                ClearControls();
                ucAlert.showAlert("WARNING", objclsFeature.featureName + " Already Exists!", "Choose Another Feature Name", "fw-bold text-danger");
            }
            else if (id > 0)
            {
                BindFeatureMaster();
                ClearControls();
                btnAddFeature.Visible = true;
                btnUpdateFeature.Visible = false;
                ucAlert.showAlert("SUCCESS", objclsFeature.featureName + "", "Added Successfully", "fw-bold text-success");
            }
        }
        private void BindFeatureMaster()
        {
            clsFeatureBAL objclsFeatureBAL = new clsFeatureBAL();
            rptFeature.DataSource = objclsFeatureBAL.GetFeatureMaster(-1, -1);
            rptFeature.DataBind();

        }
        private void BindFeatureMaster(int pkFeatureID)
        {
            clsFeatureBAL objclsFeatureBAL = new clsFeatureBAL();
            DataTable dtFeatureMaster = objclsFeatureBAL.GetFeatureMaster(pkFeatureID, -1);
            if (dtFeatureMaster.Rows.Count > 0)
            {

                if (dtFeatureMaster.Rows[0]["pkFeatureID"] != DBNull.Value)
                {
                    if (dtFeatureMaster.Rows[0]["pkFeatureID"].ToString() != string.Empty)
                    {
                        hidpkFeatureID.Value = dtFeatureMaster.Rows[0]["pkFeatureID"].ToString();
                    }
                }
                if (dtFeatureMaster.Rows[0]["featureName"] != DBNull.Value)
                {
                    if (dtFeatureMaster.Rows[0]["featureName"].ToString() != string.Empty)
                    {
                        txtFeatureName.Text = dtFeatureMaster.Rows[0]["featureName"].ToString();
                    }
                }
                if (dtFeatureMaster.Rows[0]["isActive"] != DBNull.Value)
                {
                    if (dtFeatureMaster.Rows[0]["isActive"].ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(dtFeatureMaster.Rows[0]["isActive"]))
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

        protected void rptFeature_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pkFeatureID;
            switch (e.CommandName)
            {

                case ("EditFeatureMaster"):

                    modalfeature.Show();
                    pkFeatureID = Convert.ToInt32(e.CommandArgument);
                    BindFeatureMaster(pkFeatureID);
                    btnAddFeature.Visible = false;
                    btnUpdateFeature.Visible = true;
                    break;

                case ("DisableFeatureMaster"):

                    pkFeatureID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableFeatureMaster(pkFeatureID, false);
                    break;

                case ("EnableFeatureMaster"):

                    pkFeatureID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableFeatureMaster(pkFeatureID, true);
                    break;

            }
        }
        private void EnableDisableFeatureMaster(int pkFeatureID, bool isActive)
        {
            clsFeatureBAL objclsFeatureBAL = new clsFeatureBAL();
            objclsFeatureBAL.EnableDisableFeatureMaster(pkFeatureID, isActive);

            BindFeatureMaster();

        }
        protected void ClearControls()
        {
            txtFeatureName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnUpdateFeature_Click(object sender, EventArgs e)
        {
            clsFeature objclsFeature = new clsFeature();
            objclsFeature.featureName = txtFeatureName.Text.ToString();
            objclsFeature.isActive = chkIsActive.Checked;
            clsFeatureBAL objclsFeatureBAL = new clsFeatureBAL();
            int id = objclsFeatureBAL.UpdateFeatureMaster(objclsFeature, Convert.ToInt32(hidpkFeatureID.Value));

            if (id == 0)
            {
                modalfeature.Show();
                BindFeatureMaster(Convert.ToInt32(hidpkFeatureID.Value));
                ClearControls();
                btnAddFeature.Visible = false;
                btnUpdateFeature.Visible =  true;
                ucAlert.showAlert("WARNING", objclsFeature.featureName + " Already Exists!", "Choose Another Feature Name", "fw-bold text-danger");
            }
            else if (id > 0)
            {
                BindFeatureMaster();
                ClearControls();
                btnAddFeature.Visible = true;
                btnUpdateFeature.Visible = false;
                ucAlert.showAlert("SUCCESS", objclsFeature.featureName + "", "Updated Successfully", "fw-bold text-success");
            }
            
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            ClearControls();
            btnAddFeature.Visible = true;
            btnUpdateFeature.Visible = false;
            modalfeature.Hide();
        }
    }
}