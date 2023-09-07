<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmCity.aspx.cs" Inherits="PropertyPortal.admin.frmCity" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-header">
        <h3 class="page-title">Master - Cities</h3>
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                <li class="breadcrumb-item active" aria-current="page">Cities</li>
            </ol>
        </nav>
    </div>
    <div class="row">
        <div class="col-md-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Add City</h4>
                    <div class="forms-sample">
                        <div class="form-group">
                            <label for="drpDistrict">District:</label>
                            <asp:DropDownList ID="drpDistrict" CssClass="form-control form-control-sm" runat="server" ValidationGroup="validate"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="reqdrpDistrict" runat="server" ControlToValidate="drpDistrict" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <label for="txtCityName">City Name:</label>
                            <asp:TextBox ID="txtCityName" CssClass="form-control form-control-sm" runat="server" placeholder="City Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtCityName" runat="server" ControlToValidate="txtCityName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-check form-check-flat form-check-primary">
                            <span class="form-check-label">
                                <asp:CheckBox ID="chkIsActive" runat="server" ValidationGroup="validate" />
                                Is Active? <i class="input-helper"></i>
                            </span>
                        </div>
                        <asp:HiddenField ID="hidpkCityID" runat="server" />
                        <asp:Button ID="btnAddCity" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" OnClick="btnAddCity_Click"
                            ValidationGroup="validate" />
                        <asp:Button ID="btnUpdateCity" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" OnClick="btnUpdateCity_Click"
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
                    <h4 class="card-title">All Cities</h4>
                    <asp:Repeater ID="rptCity" runat="server" OnItemCommand="rptCity_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-bordered sortTable">
                                <thead class="table-dark">
                                    <tr>
                                        <th># </th>
                                        <th>City Name </th>
                                        <th>Is Active? </th>
                                        <th>Action </th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Container.ItemIndex + 1 + "." %></td>
                                <td><%# Eval("cityName") %> </td>
                                <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                                <td>
                                    <asp:Button ID="btnEditCity" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                        CommandName="EditCityMaster" CommandArgument='<%# Eval("pkCityID") %>' Text="Edit" />
                                    <asp:Button ID="btnDisableCity" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                        CommandName="DisableCityMaster" CommandArgument='<%# Eval("pkCityID") %>' Text="Disable" />
                                    <asp:Button ID="btnEnableCity" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                        CommandName="EnableCityMaster" CommandArgument='<%# Eval("pkCityID") %>' Text="Enable" />
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
