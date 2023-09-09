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
    public partial class frmRentType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRentTypeMaster();
            }
        }

        protected void btnAddRentType_Click(object sender, EventArgs e)
        {
            clsRentType objclsRentType = new clsRentType();
            objclsRentType.rentTypeName = txtRentTypeName.Text.ToString();
            objclsRentType.isActive = chkIsActive.Checked;
            objclsRentType.createdBy = Convert.ToInt32(Session["pkLoginID"]);

            clsRentTypeBAL objclsRentTypeBAL = new clsRentTypeBAL();
            

            int id = objclsRentTypeBAL.AddRentTypeMaster(objclsRentType);

            if (id == 0)
            {
                
                ucAlert.showAlert("WARNING", objclsRentType.rentTypeName + " Already Exists!", "Choose Another Rent Type Name", "fw-bold text-danger");
            }
            else if (id > 0)
            {
                BindRentTypeMaster();
                ClearControls();
                btnAddRentType.Visible = true;
                btnUpdateRentType.Visible = false;
                ucAlert.showAlert("SUCCESS", objclsRentType.rentTypeName + "", "Updated Successfully", "fw-bold text-success");
            }
        }
        private void BindRentTypeMaster()
        {
            clsRentTypeBAL objclsRentTypeBAL = new clsRentTypeBAL();
            rptRentType.DataSource = objclsRentTypeBAL.GetRentTypeMaster(-1, -1);
            rptRentType.DataBind();

        }
        private void BindRentTypeMaster(int pkRentTypeID)
        {
            clsRentTypeBAL objclsRentTypeBAL = new clsRentTypeBAL();
            DataTable dtRentTypeMaster = objclsRentTypeBAL.GetRentTypeMaster(pkRentTypeID, -1);
            if (dtRentTypeMaster.Rows.Count > 0)
            {

                if (dtRentTypeMaster.Rows[0]["pkRentTypeID"] != DBNull.Value)
                {
                    if (dtRentTypeMaster.Rows[0]["pkRentTypeID"].ToString() != string.Empty)
                    {
                        hidpkRentTypeID.Value = dtRentTypeMaster.Rows[0]["pkRentTypeID"].ToString();
                    }
                }
                if (dtRentTypeMaster.Rows[0]["rentTypeName"] != DBNull.Value)
                {
                    if (dtRentTypeMaster.Rows[0]["rentTypeName"].ToString() != string.Empty)
                    {
                        txtRentTypeName.Text = dtRentTypeMaster.Rows[0]["rentTypeName"].ToString();
                    }
                }
                if (dtRentTypeMaster.Rows[0]["isActive"] != DBNull.Value)
                {
                    if (dtRentTypeMaster.Rows[0]["isActive"].ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(dtRentTypeMaster.Rows[0]["isActive"]))
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

        protected void rptRentType_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pkRentTypeID;
            switch (e.CommandName)
            {

                case ("EditRentTypeMaster"):

                    modalRentType.Show();
                    pkRentTypeID = Convert.ToInt32(e.CommandArgument);
                    BindRentTypeMaster(pkRentTypeID);
                    btnAddRentType.Visible = false;
                    btnUpdateRentType.Visible = true;
                    break;

                case ("DisableRentTypeMaster"):

                    pkRentTypeID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableRentTypeMaster(pkRentTypeID, false);
                    break;

                case ("EnableRentTypeMaster"):

                    pkRentTypeID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableRentTypeMaster(pkRentTypeID, true);
                    break;

            }
        }
        private void EnableDisableRentTypeMaster(int pkRentTypeID, bool isActive)
        {
            clsRentTypeBAL objclsRentTypeBAL = new clsRentTypeBAL();
            objclsRentTypeBAL.EnableDisableRentTypeMaster(pkRentTypeID, isActive);

            BindRentTypeMaster();

        }
        protected void ClearControls()
        {
            txtRentTypeName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnUpdateRentType_Click(object sender, EventArgs e)
        {
            clsRentType objclsRentType = new clsRentType();
            objclsRentType.rentTypeName = txtRentTypeName.Text.ToString();
            objclsRentType.isActive = chkIsActive.Checked;

            clsRentTypeBAL objclsRentTypeBAL = new clsRentTypeBAL();
            

            int id = objclsRentTypeBAL.UpdateRentTypeMaster(objclsRentType, Convert.ToInt32(hidpkRentTypeID.Value));

            if (id == 0)
            {
                modalRentType.Show();
                BindRentTypeMaster(Convert.ToInt32(hidpkRentTypeID.Value));
                btnAddRentType.Visible = false;
                btnUpdateRentType.Visible = true;
                ucAlert.showAlert("WARNING", objclsRentType.rentTypeName + " Already Exists!", "Choose Another Rent Type Name", "fw-bold text-danger");
            }
            else if (id > 0)
            {
                BindRentTypeMaster();
                ClearControls();
                btnAddRentType.Visible = true;
                btnUpdateRentType.Visible = false;
                ucAlert.showAlert("SUCCESS", objclsRentType.rentTypeName + "", "Updated Successfully", "fw-bold text-success");
            }
            
        }
        protected void btnClosedistrict_Click(object sender, EventArgs e)
        {
            ClearControls();
            btnAddRentType.Visible = true;
            btnUpdateRentType.Visible = false;
            modalRentType.Hide();
        }
    }
}