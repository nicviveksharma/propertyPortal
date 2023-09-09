<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmPropertyType.aspx.cs" Inherits="PropertyPortal.admin.frmPropertyType" %>

<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <uc1:ucAlert runat="server" ID="ucAlert" />
            <ajaxToolkit:ModalPopupExtender ID="modalPropertyType" runat="server" TargetControlID="btnOpendistrict"
                PopupControlID="pnlModal" BackgroundCssClass="modalBackground" />
            <div class="page-header">
                <h3 class="page-title">Master - Property Types</h3>
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                        <li class="breadcrumb-item active" aria-current="page">Property Types</li>
                    </ol>
                </nav>
            </div>
            <div class="row">
                <div class="col-md-12 grid-margin stretch-card">
                    <asp:Button ID="btnOpendistrict" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Add New" />
                </div>
            </div>
            <asp:Panel ID="pnlModal" runat="server" CssClass="modalPopup" Style="display: none">
                <div class="row">
                    <div class="col-md-12 grid-margin stretch-card">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="card-title">Add Property Type</h4>
                                <div class="forms-sample">
                                    <div class="form-group">
                                        <label for="txtPropertyTypeName">Property Type Name:</label>
                                        <asp:TextBox ID="txtPropertyTypeName" CssClass="form-control form-control-sm" runat="server" placeholder="Property Type Name" ValidationGroup="validate"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="reqtxtPropertyTypeName" runat="server" ControlToValidate="txtPropertyTypeName" Display="Dynamic"
                                            ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="form-check form-check-flat form-check-primary">
                                        <span class="form-check-label">
                                            <asp:CheckBox ID="chkIsActive" runat="server" ValidationGroup="validate" />
                                            Is Active? <i class="input-helper"></i>
                                        </span>
                                    </div>
                                    <asp:HiddenField ID="hidpkPropertyTypeID" runat="server" />
                                    <asp:Button ID="btnAddPropertyType" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" OnClick="btnAddPropertyType_Click"
                                        ValidationGroup="validate" />
                                    <asp:Button ID="btnUpdatePropertyType" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" OnClick="btnUpdatePropertyType_Click"
                                        ValidationGroup="validate" Visible="false" />
                                    <asp:Button ID="btnClose" CssClass="btn btn-mb-0 btn-danger" runat="server" Text="Close" OnClick="btnDummy_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <div class="row">
                <div class="col-lg-12 stretch-card">
                    <div class="card">
                        <div class="card-body">
                            <h4 class="card-title">All Property Types</h4>
                            <asp:Repeater ID="rptPropertyType" runat="server" OnItemCommand="rptPropertyType_ItemCommand">
                                <HeaderTemplate>
                                    <table class="table table-bordered sortTable">
                                        <thead class="table-dark">
                                            <tr>
                                                <th># </th>
                                                <th>Property Type Name </th>
                                                <th>Is Active? </th>
                                                <th>Action </th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Container.ItemIndex + 1 + "." %></td>
                                        <td><%# Eval("propertyTypeName") %> </td>
                                        <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                                        <td>
                                            <asp:Button ID="btnEditPropertyType" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                                CommandName="EditPropertyTypeMaster" CommandArgument='<%# Eval("pkPropertyTypeID") %>' Text="Edit" />
                                            <asp:Button ID="btnDisablePropertyType" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                                CommandName="DisablePropertyTypeMaster" CommandArgument='<%# Eval("pkPropertyTypeID") %>' Text="Disable" />
                                            <asp:Button ID="btnEnablePropertyType" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                                CommandName="EnablePropertyTypeMaster" CommandArgument='<%# Eval("pkPropertyTypeID") %>' Text="Enable" />
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
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
