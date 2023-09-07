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
    public partial class frmState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindStateMaster();
            }
        }
        protected void btnAddState_Click(object sender, EventArgs e)
        {
            clsState objclsState = new clsState();
            objclsState.stateName = txtStateName.Text.ToString();
            objclsState.isActive = chkIsActive.Checked;
            objclsState.createdBy = Convert.ToInt32(Session["pkLoginID"]);

            clsStateBAL objclsStateBAL = new clsStateBAL();
            int id = objclsStateBAL.AddStateMaster(objclsState);

            if (id == 0)
            {
                modaldistrict.Show();
                btnAddState.Visible = true;
                btnUpdateState.Visible = false;
                ucAlert.showAlert("WARNING", objclsState.stateName + " Already Exists!", "Choose Another State Name", "fw-bold text-danger");
            }
            else if (id > 0)
            {
                BindStateMaster();
                ClearControls();
                btnAddState.Visible = true;
                btnUpdateState.Visible = false;
            }
        }
        private void BindStateMaster()
        {
            clsStateBAL objclsStateBAL = new clsStateBAL();
            rptState.DataSource = objclsStateBAL.GetStateMaster(-1, -1);
            rptState.DataBind();

        }
        private void BindStateMaster(int pkStateID)
        {
            clsStateBAL objclsStateBAL = new clsStateBAL();
            DataTable dtStateMaster = objclsStateBAL.GetStateMaster(pkStateID, -1);
            if (dtStateMaster.Rows.Count > 0)
            {

                if (dtStateMaster.Rows[0]["pkStateID"] != DBNull.Value)
                {
                    if (dtStateMaster.Rows[0]["pkStateID"].ToString() != string.Empty)
                    {
                        hidpkStateID.Value = dtStateMaster.Rows[0]["pkStateID"].ToString();
                    }
                }
                if (dtStateMaster.Rows[0]["stateName"] != DBNull.Value)
                {
                    if (dtStateMaster.Rows[0]["stateName"].ToString() != string.Empty)
                    {
                        txtStateName.Text = dtStateMaster.Rows[0]["stateName"].ToString();
                    }
                }
                if (dtStateMaster.Rows[0]["isActive"] != DBNull.Value)
                {
                    if (dtStateMaster.Rows[0]["isActive"].ToString() != string.Empty)
                    {
                        if (Convert.ToBoolean(dtStateMaster.Rows[0]["isActive"]))
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

        protected void rptState_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int pkStateID;
            switch (e.CommandName)
            {

                case ("EditStateMaster"):

                    modaldistrict.Show();
                    pkStateID = Convert.ToInt32(e.CommandArgument);
                    BindStateMaster(pkStateID);
                    btnAddState.Visible = false;
                    btnUpdateState.Visible = true;
                    break;

                case ("DisableStateMaster"):

                    pkStateID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableStateMaster(pkStateID, false);
                    break;

                case ("EnableStateMaster"):

                    pkStateID = Convert.ToInt32(e.CommandArgument);
                    EnableDisableStateMaster(pkStateID, true);
                    break;

            }
        }
        private void EnableDisableStateMaster(int pkStateID, bool isActive)
        {
            clsStateBAL objclsStateBAL = new clsStateBAL();
            objclsStateBAL.EnableDisableStateMaster(pkStateID, isActive);

            BindStateMaster();

        }
        protected void ClearControls()
        {
            txtStateName.Text = string.Empty;
            chkIsActive.Checked = false;
        }

        protected void btnUpdateState_Click(object sender, EventArgs e)
        {
            clsState objclsState = new clsState();
            objclsState.stateName = txtStateName.Text.ToString();
            objclsState.isActive = chkIsActive.Checked;

            clsStateBAL objclsStateBAL = new clsStateBAL();
            int id = objclsStateBAL.UpdateStateMaster(objclsState, Convert.ToInt32(hidpkStateID.Value));

            if (id == 0)
            {
                modaldistrict.Show();
                BindStateMaster(Convert.ToInt32(hidpkStateID.Value));
                btnAddState.Visible = false;
                btnUpdateState.Visible = true;
                ucAlert.showAlert("WARNING", objclsState.stateName + " Already Exists!", "Choose Another State Name", "fw-bold text-danger");

            }
            else if (id > 0)
            {
                BindStateMaster();
                ClearControls();
                btnAddState.Visible = true;
                btnUpdateState.Visible = false;
                ucAlert.showAlert("SUCCESS", objclsState.stateName + "", "Updated Successfully", "fw-bold text-success");
            }


        }
        protected void btnDummy_Click(object sender, EventArgs e)
        {
            ClearControls();
            btnAddState.Visible = true;
            btnUpdateState.Visible = false;
            modaldistrict.Hide();
        }
    }
}