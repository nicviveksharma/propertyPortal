<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucManager.ascx.cs" Inherits="PropertyPortal.usercontrol.ucManager" %>
<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>


<div class="row">
    <div class="col-md-12 grid-margin ">
        <div class="card">
            <div class="card-body">
                <uc1:ucAlert runat="server" ID="ucAlert" />
                <h4 class="card-title">Manager Details</h4>
                <div class="forms-sample row">
                    <div class="col-md-4">
                        <div class="form-group">
                            <label for="txtUserFirstName">First Name:</label>
                            <asp:TextBox ID="txtUserFirstName" CssClass="form-control form-control-sm" runat="server" placeholder="First Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtUserFirstName" runat="server" ControlToValidate="txtUserFirstName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label for="txtUserMiddleName">Middle Name:</label>
                            <asp:TextBox ID="txtUserMiddleName" CssClass="form-control form-control-sm" runat="server" placeholder="Middle Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtUserMiddleName" runat="server" ControlToValidate="txtUserMiddleName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <div class="form-group">
                            <label for="txtUserLastName">Last Name:</label>
                            <asp:TextBox ID="txtUserLastName" CssClass="form-control form-control-sm" runat="server" placeholder="Last Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtUserLastName" runat="server" ControlToValidate="txtUserLastName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="txtUserEmailAddress">Email Address / Username:</label>
                            <asp:TextBox ID="txtUserEmailAddress" CssClass="form-control form-control-sm" runat="server" placeholder="Email Address" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtUserEmailAddress" runat="server" ControlToValidate="txtUserEmailAddress" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="txtUserMobileNo">Mobile No:</label>
                            <asp:TextBox ID="txtUserMobileNo" CssClass="form-control form-control-sm" runat="server" placeholder="Mobile No" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtUserMobileNo" runat="server" ControlToValidate="txtUserMobileNo" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="txtLoginPassword">Password:</label>
                            <asp:TextBox ID="txtLoginPassword" CssClass="form-control form-control-sm loginpassword" runat="server" placeholder="Password" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtLoginPassword" runat="server" ControlToValidate="txtLoginPassword" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-6">
                        <div class="form-group">
                            <label for="txtLoginConfirmPassword">Confirm Password:</label>
                            <asp:TextBox ID="txtLoginConfirmPassword" CssClass="form-control form-control-sm loginpassword2" runat="server" placeholder="Confirm Password" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtLoginConfirmPassword" runat="server" ControlToValidate="txtLoginConfirmPassword" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="col-md-12 d-none">
                        <div class="form-group">
                            <label for="txtUserCompanyName">Company Name:</label>
                            <asp:TextBox ID="txtUserCompanyName" CssClass="form-control form-control-sm" runat="server" placeholder="Company Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtUserCompanyName" runat="server" ControlToValidate="txtUserCompanyName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-12 d-none">
                        <div class="form-group">
                            <label for="txtUserCompanyAddress">Company Address:</label>
                            <asp:TextBox ID="txtUserCompanyAddress" TextMode="MultiLine" Rows="8" CssClass="form-control form-control-sm" runat="server" placeholder="Company Address" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtUserCompanyAddress" runat="server" ControlToValidate="txtUserCompanyAddress" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-4">
                        <asp:HiddenField ID="hidpkLoginID" runat="server" />
                        <asp:Button ID="btnAddUser" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" ValidationGroup="validate"  OnClick="btnAddUser_Click"/>
                        <asp:Button ID="btnUpdateUser" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" ValidationGroup="validate" Visible="false" OnClick="btnUpdateUser_Click"/>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
