<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="PropertyPortal.adminlogin" %>

<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="captcha" %>
<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <uc1:ucAlert runat="server" ID="ucAlert" />
            <div class="container-xxl py-5">
                <div class="container">
                    <div class="text-center mx-auto mb-5 wow fadeInUp" data-wow-delay="0.1s" style="max-width: 600px;">
                        <h1 class="mb-3">Log In</h1>
                        <p>Login using your email/username and manage your profile and properties.</p>
                    </div>
                    <div class="row g-4">
                        <div class="col-md-6 mx-auto mb-5">
                            <div class="wow fadeInUp" data-wow-delay="0.5s">
                                <div class="row g-3">
                                    <div class="col-md-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="txtUsername" CssClass="form-control form-control-lg" runat="server" placeholder="Enter Username"></asp:TextBox>
                                            <label for="txtUsername">Enter Username</label>
                                            <asp:RequiredFieldValidator ID="reqtxtUsername" Display="Dynamic" ErrorMessage="* - Required" CssClass="text-danger errormessage" runat="server"
                                                ControlToValidate="txtUsername" ValidationGroup="error">
                                            </asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <div class="form-floating">
                                            <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control form-control-lg loginpassword" runat="server" placeholder="Enter Password"></asp:TextBox>
                                            <label for="txtPassword">Enter Password</label>
                                            <asp:RequiredFieldValidator ID="reqtxtPassword" Display="Dynamic" ErrorMessage="* - Required" CssClass="text-danger errormessage" runat="server"
                                                ControlToValidate="txtPassword" ValidationGroup="error">
                                            </asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <div class="form-floating">
                                            <asp:TextBox ID="txtcaptcha" CssClass="form-control" runat="server" placeholder="Enter Captcha"></asp:TextBox>
                                            <label for="txtcaptcha">Enter Captcha</label>
                                            <asp:RequiredFieldValidator ID="reqtxtcaptcha" Display="Dynamic" ErrorMessage="* - Required" CssClass="text-danger errormessage" runat="server"
                                                ControlToValidate="txtcaptcha" ValidationGroup="error">
                                            </asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <div class="form-floating">
                                            <captcha:CaptchaControl ID="cptCaptcha" runat="server" CaptchaBackgroundNoise="Low" CaptchaLength="5"
                                                CaptchaHeight="40" CaptchaWidth="180" CaptchaLineNoise="Low" CaptchaMinTimeout="5"
                                                CaptchaMaxTimeout="240" FontColor="#529E00" />
                                        </div>
                                    </div>
                                    <div class="col-md-2">
                                        <div class="form-floating">
                                            <asp:ImageButton ImageUrl="assets/images/refresh.png" AlternateText="Refresh Captcha" ToolTip="Refresh Captcha" Width="35" runat="server" CausesValidation="false" />
                                        </div>
                                    </div>
                                    <div class="col-md-12">
                                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn btn-dark border-0 w-50 py-3" ValidationGroup="error" />
                                        <a href="#" class="auth-link text-black">Forgot password?</a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
