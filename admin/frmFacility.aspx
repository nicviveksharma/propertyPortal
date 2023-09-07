<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmFacility.aspx.cs" Inherits="PropertyPortal.admin.frmFacility" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-header">
        <h3 class="page-title">Master - Facilities</h3>
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                <li class="breadcrumb-item active" aria-current="page">Facilities</li>
            </ol>
        </nav>
    </div>
    <div class="row">
        <div class="col-md-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Add Facility</h4>
                    <div class="forms-sample">
                        <div class="form-group">
                            <label for="txtFacilityName">Facility Name:</label>
                            <asp:TextBox ID="txtFacilityName" CssClass="form-control form-control-sm" runat="server" placeholder="Facility Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtFacilityName" runat="server" ControlToValidate="txtFacilityName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-check form-check-flat form-check-primary">
                            <span class="form-check-label">
                                <asp:CheckBox ID="chkIsActive" runat="server" ValidationGroup="validate" />
                                Is Active? <i class="input-helper"></i>
                            </span>
                        </div>
                        <asp:HiddenField ID="hidpkFacilityID" runat="server" />
                        <asp:Button ID="btnAddFacility" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" OnClick="btnAddFacility_Click"
                            ValidationGroup="validate" />
                        <asp:Button ID="btnUpdateFacility" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" OnClick="btnUpdateFacility_Click"
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
                    <h4 class="card-title">All Facilitys</h4>
                    <asp:Repeater ID="rptFacility" runat="server" OnItemCommand="rptFacility_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-bordered sortTable">
                                <thead class="table-dark">
                                    <tr>
                                        <th># </th>
                                        <th>Facility Name </th>
                                        <th>Is Active? </th>
                                        <th>Action </th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Container.ItemIndex + 1 + "." %></td>
                                <td><%# Eval("facilityName") %> </td>
                                <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                                <td>
                                    <asp:Button ID="btnEditFacility" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                        CommandName="EditFacilityMaster" CommandArgument='<%# Eval("pkFacilityID") %>' Text="Edit" />
                                    <asp:Button ID="btnDisableFacility" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                        CommandName="DisableFacilityMaster" CommandArgument='<%# Eval("pkFacilityID") %>' Text="Disable" />
                                    <asp:Button ID="btnEnableFacility" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                        CommandName="EnableFacilityMaster" CommandArgument='<%# Eval("pkFacilityID") %>' Text="Enable" />
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
