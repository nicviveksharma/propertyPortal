<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmDistrict.aspx.cs" Inherits="PropertyPortal.admin.frmDistrict" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-header">
        <h3 class="page-title">Master - Districts</h3>
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                <li class="breadcrumb-item active" aria-current="page">Districts</li>
            </ol>
        </nav>
    </div>
    <div class="row">
        <div class="col-md-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Add District</h4>
                    <div class="forms-sample">
                        <div class="form-group">
                            <label for="drpState">State:</label>
                            <asp:DropDownList ID="drpState" CssClass="form-control form-control-sm" runat="server" ValidationGroup="validate"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="reqdrpState" runat="server" ControlToValidate="drpState" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="txtDistrictName">District Name:</label>
                            <asp:TextBox ID="txtDistrictName" CssClass="form-control form-control-sm" runat="server" placeholder="District Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtDistrictName" runat="server" ControlToValidate="txtDistrictName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-check form-check-flat form-check-primary">
                            <span class="form-check-label">
                                <asp:CheckBox ID="chkIsActive" runat="server" ValidationGroup="validate" />
                                Is Active? <i class="input-helper"></i>
                            </span>
                        </div>
                        <asp:HiddenField ID="hidpkDistrictID" runat="server" />
                        <asp:Button ID="btnAddDistrict" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" OnClick="btnAddDistrict_Click"
                            ValidationGroup="validate" />
                        <asp:Button ID="btnUpdateDistrict" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" OnClick="btnUpdateDistrict_Click"
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
                    <h4 class="card-title">All Districts</h4>
                    <asp:Repeater ID="rptDistrict" runat="server" OnItemCommand="rptDistrict_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-bordered sortTable">
                                <thead class="table-dark">
                                    <tr>
                                        <th># </th>
                                        <th>District Name </th>
                                        <th>Is Active? </th>
                                        <th>Action </th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Container.ItemIndex + 1 + "." %></td>
                                <td><%# Eval("districtName") %> </td>
                                <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                                <td>
                                    <asp:Button ID="btnEditDistrict" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                        CommandName="EditDistrictMaster" CommandArgument='<%# Eval("pkDistrictID") %>' Text="Edit" />
                                    <asp:Button ID="btnDisableDistrict" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                        CommandName="DisableDistrictMaster" CommandArgument='<%# Eval("pkDistrictID") %>' Text="Disable" />
                                    <asp:Button ID="btnEnableDistrict" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                        CommandName="EnableDistrictMaster" CommandArgument='<%# Eval("pkDistrictID") %>' Text="Enable" />
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
