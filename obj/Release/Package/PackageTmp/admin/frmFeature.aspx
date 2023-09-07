<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmFeature.aspx.cs" Inherits="PropertyPortal.admin.frmFeature" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-header">
        <h3 class="page-title">Master - Features</h3>
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                <li class="breadcrumb-item active" aria-current="page">Features</li>
            </ol>
        </nav>
    </div>
    <div class="row">
        <div class="col-md-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Add Feature</h4>
                    <div class="forms-sample">
                        <div class="form-group">
                            <label for="txtFeatureName">Feature Name:</label>
                            <asp:TextBox ID="txtFeatureName" CssClass="form-control form-control-sm" runat="server" placeholder="Feature Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtFeatureName" runat="server" ControlToValidate="txtFeatureName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-check form-check-flat form-check-primary">
                            <span class="form-check-label">
                                <asp:CheckBox ID="chkIsActive" runat="server" ValidationGroup="validate" />
                                Is Active? <i class="input-helper"></i>
                            </span>
                        </div>
                        <asp:HiddenField ID="hidpkFeatureID" runat="server" />
                        <asp:Button ID="btnAddFeature" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" OnClick="btnAddFeature_Click"
                            ValidationGroup="validate" />
                        <asp:Button ID="btnUpdateFeature" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" OnClick="btnUpdateFeature_Click"
                            ValidationGroup="validate" Visible="false" />
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-12 stretch-card">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">All Features</h4>
                    <asp:Repeater ID="rptFeature" runat="server" OnItemCommand="rptFeature_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-bordered sortTable">
                                <thead class="table-dark">
                                    <tr>
                                        <th># </th>
                                        <th>Feature Name </th>
                                        <th>Is Active? </th>
                                        <th>Action </th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Container.ItemIndex + 1 + "." %></td>
                                <td><%# Eval("featureName") %> </td>
                                <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                                <td>
                                    <asp:Button ID="btnEditFeature" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                        CommandName="EditFeatureMaster" CommandArgument='<%# Eval("pkFeatureID") %>' Text="Edit" />
                                    <asp:Button ID="btnDisableFeature" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                        CommandName="DisableFeatureMaster" CommandArgument='<%# Eval("pkFeatureID") %>' Text="Disable" />
                                    <asp:Button ID="btnEnableFeature" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                        CommandName="EnableFeatureMaster" CommandArgument='<%# Eval("pkFeatureID") %>' Text="Enable" />
                                </td>
                            </tr>
                        </ItemTemplate>
                        <FooterTemplate>
                            </tbody>
                            </table>
                        </FooterTemplate>
                    </asp:Repeater>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
