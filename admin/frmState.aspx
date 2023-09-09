<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmState.aspx.cs" Inherits="PropertyPortal.admin.frmState" %>

<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <ajaxToolkit:ModalPopupExtender ID="modaldistrict" runat="server" TargetControlID="btnDummySTATE"
                PopupControlID="pnlModal" BackgroundCssClass="modalBackground"  />
            <uc1:ucAlert runat="server" ID="ucAlert" />
            <div class="page-header">
                <h3 class="page-title">Master - States</h3>
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                        <li class="breadcrumb-item active" aria-current="page">States</li>
                    </ol>
                </nav>
            </div>
            <div class="row">
                <div class="col-md-12 grid-margin stretch-card">
                    <asp:Button ID="btnDummySTATE" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Add New" />
                </div>
            </div>
            <asp:Panel ID="pnlModal" runat="server" CssClass="modalPopup" Style="display: none">
                <div class="row">
                    <div class="col-md-12 grid-margin stretch-card">
                        <div class="card">
                            <div class="card-body">
                                <h4 class="card-title">Add State</h4>
                                <div class="forms-sample">
                                    <div class="form-group">
                                        <label for="txtStateName">State Name:</label>
                                        <asp:TextBox ID="txtStateName" CssClass="form-control form-control-sm" runat="server" placeholder="State Name" ValidationGroup="validate"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="reqtxtStateName" runat="server" ControlToValidate="txtStateName" Display="Dynamic"
                                            ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                                    </div>
                                    <div class="form-check form-check-flat form-check-primary">
                                        <span class="form-check-label">
                                            <asp:CheckBox ID="chkIsActive" runat="server" ValidationGroup="validate" />
                                            Is Active? <i class="input-helper"></i>
                                        </span>
                                    </div>
                                    <asp:HiddenField ID="hidpkStateID" runat="server" />
                                    <asp:Button ID="btnAddState" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" OnClick="btnAddState_Click"
                                        ValidationGroup="validate" />
                                    <asp:Button ID="btnUpdateState" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" OnClick="btnUpdateState_Click"
                                        ValidationGroup="validate" Visible="false" />
                                    <asp:Button ID="btnCloseSTATE" CssClass="btn btn-mb-0 btn-danger" runat="server" Text="Close" OnClick="btnDummy_Click"/>
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
                            <h4 class="card-title">All States</h4>
                            <asp:Repeater ID="rptState" runat="server" OnItemCommand="rptState_ItemCommand">
                                <HeaderTemplate>
                                    <table class="table table-bordered sortTable">
                                        <thead class="table-dark">
                                            <tr>
                                                <th># </th>
                                                <th>State Name </th>
                                                <th>Is Active? </th>
                                                <th>Action </th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Container.ItemIndex + 1 + "." %></td>
                                        <td><%# Eval("stateName") %> </td>
                                        <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                                        <td>
                                            <asp:Button ID="btnEditState" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                                CommandName="EditStateMaster" CommandArgument='<%# Eval("pkStateID") %>' Text="Edit" />
                                            <asp:Button ID="btnDisableState" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                                CommandName="DisableStateMaster" CommandArgument='<%# Eval("pkStateID") %>' Text="Disable" />
                                            <asp:Button ID="btnEnableState" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                                CommandName="EnableStateMaster" CommandArgument='<%# Eval("pkStateID") %>' Text="Enable" />
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
