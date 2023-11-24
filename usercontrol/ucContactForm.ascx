<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucContactForm.ascx.cs" Inherits="PropertyPortal.usercontrol.ucContactForm" %>

<%@ Register Assembly="MSCaptcha" Namespace="MSCaptcha" TagPrefix="captcha" %>
<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>

<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <uc1:ucAlert runat="server" ID="ucAlert" />
        <div class="row">
            <div class="col-md-6">
                <div class="wow fadeInUp" data-wow-delay="0.5s">
                    <p class="mb-4">This form is currently inactive. </p>
                    <div class="row g-3">
                        <div class="col-md-6">
                            <div class="form-floating">
                                <asp:TextBox runat="server" ValidationGroup="validate" type="text" class="form-control" ID="txtName" placeholder="Your Name"></asp:TextBox>
                                <label for="txtName">Name</label>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-floating">
                                <asp:TextBox runat="server" ValidationGroup="validate" TextMode="Phone" class="form-control" ID="txtMobile" placeholder="Your Mobile"></asp:TextBox>
                                <label for="txtMobile">Mobile</label>
                            </div>
                        </div>
                        <div class="col-12">
                            <div class="form-floating">
                                <asp:TextBox runat="server" ValidationGroup="validate" TextMode="Email" class="form-control" ID="txtEmail" placeholder="Your Email"></asp:TextBox>
                                <label for="txtEmail">Email</label>
                            </div>
                        </div>
                        <div class="col-12">
                            <div class="form-floating">
                                <asp:TextBox runat="server" ValidationGroup="validate" TextMode="MultiLine" class="form-control" ID="txtAdress" placeholder="Your Address"></asp:TextBox>
                                <label for="txtAdress">Address</label>
                            </div>
                        </div>
                        <div class="col-12">
                            <div class="form-floating">
                                <asp:TextBox runat="server" ValidationGroup="validate" TextMode="MultiLine" class="form-control" ID="txtMessage" placeholder="Your Message"></asp:TextBox>
                                <label for="txtMessage">Message</label>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-floating">
                                <asp:TextBox ID="txtcaptcha" CssClass="form-control" runat="server" placeholder="Enter Captcha" Text=""></asp:TextBox>
                                <label for="txtcaptcha">Enter Captcha</label>
                                <asp:RequiredFieldValidator ID="reqtxtcaptcha" Display="Dynamic" ErrorMessage="* - Required" CssClass="text-danger errormessage" runat="server"
                                    ControlToValidate="txtcaptcha" ValidationGroup="validate">
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
                        <div class="col-12">
                            <asp:Button runat="server" ID="submit" ValidationGroup="validate" class="btn btn-primary w-10 py-3" type="submit" Text="Submit" OnClick="submit_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
