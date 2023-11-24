﻿using PropertyPortal.BAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PropertyPortal
{
    public partial class adminlogin : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                cptCaptcha.ValidateCaptcha(txtCaptcha.Text.Trim());
                if (cptCaptcha.UserValidated)
                {
                    if (txtPassword.Text.Trim() != string.Empty)
                    {
                        clsLoginBAL objclsLoginBAL = new clsLoginBAL();
                        DataTable dtLogin = objclsLoginBAL.GetLogin(txtUsername.Text, Convert.ToInt32(drpLoginRole.SelectedValue));
                        if (dtLogin.Rows.Count > 0)
                        {
                            string pass = functions.clsLoginFunctions.HashPassword(txtPassword.Text, dtLogin.Rows[0]["loginSalt"].ToString());
                            string pass2 = dtLogin.Rows[0]["loginPassword"].ToString();
                            bool isVerified = Convert.ToBoolean(dtLogin.Rows[0]["isVerified"]);

                            if (isVerified)
                            {
                                bool isActive = Convert.ToBoolean(dtLogin.Rows[0]["isActive"]);
                                if (isActive)
                                {
                                    //if( 1 == 1)
                                    if (pass == pass2)
                                    {
                                        string userRole = dtLogin.Rows[0]["loginRole"].ToString();
                                        Session["pkLoginID"] = dtLogin.Rows[0]["pkLoginID"];
                                        Session["loginRole"] = dtLogin.Rows[0]["loginRole"];
                                        Session["userFirstName"] = dtLogin.Rows[0]["fullName"];
                                        if(userRole== functions.clsCommonFunctions.getConfig("admin"))
                                        {
                                            Response.Redirect(functions.clsCommonFunctions.getConfig("admindashboard"));
                                        }
                                        if (userRole == functions.clsCommonFunctions.getConfig("manager"))
                                        {
                                            Response.Redirect(functions.clsCommonFunctions.getConfig("managerdashboard"));
                                        }
                                    }
                                    else
                                    {
                                        ucAlert.showAlert("Invalid Login", "Invalid Password, use valid password and try again!", string.Empty);
                                    }
                                }
                                else
                                {
                                    ucAlert.showAlert("Login In-Active", "User is not active yet, contact admin!", string.Empty);
                                }
                            }
                            else
                            {
                                ucAlert.showAlert("Login Unverified", "User is not verified yet, contact admin!", string.Empty);
                            }
                        }
                        else
                        {
                            ucAlert.showAlert("Invalid Login", "Invalid Username, use valid username and try again!", string.Empty);
                        }
                    }
                    else
                    {
                        ucAlert.showAlert("Password Empty", "Use a valid password!", string.Empty);
                    }
                }
                else
                {
                    ucAlert.showAlert("Invalid Captcha", "Invalid Captcha, try again!", string.Empty);
                }
            }
        }
    }
}