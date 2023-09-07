﻿<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmRentType.aspx.cs" Inherits="PropertyPortal.admin.frmRentType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="page-header">
        <h3 class="page-title">Master - Rent Types</h3>
        <nav aria-label="breadcrumb">
            <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                <li class="breadcrumb-item active" aria-current="page">Rent Types</li>
            </ol>
        </nav>
    </div>
    <div class="row">
        <div class="col-md-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Add Rent Type</h4>
                    <div class="forms-sample">
                        <div class="form-group">
                            <label for="txtRentTypeName">Rent Type Name:</label>
                            <asp:TextBox ID="txtRentTypeName" CssClass="form-control form-control-sm" runat="server" placeholder="Rent Type Name" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtRentTypeName" runat="server" ControlToValidate="txtRentTypeName" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-check form-check-flat form-check-primary">
                            <span class="form-check-label">
                                <asp:CheckBox ID="chkIsActive" runat="server" ValidationGroup="validate" />
                                Is Active? <i class="input-helper"></i>
                            </span>
                        </div>
                        <asp:HiddenField ID="hidpkRentTypeID" runat="server" />
                        <asp:Button ID="btnAddRentType" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" OnClick="btnAddRentType_Click"
                            ValidationGroup="validate" />
                        <asp:Button ID="btnUpdateRentType" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" OnClick="btnUpdateRentType_Click"
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
                    <h4 class="card-title">All Rent Types</h4>
                    <asp:Repeater ID="rptRentType" runat="server" OnItemCommand="rptRentType_ItemCommand">
                        <HeaderTemplate>
                            <table class="table table-bordered sortTable">
                                <thead class="table-dark">
                                    <tr>
                                        <th># </th>
                                        <th>Rent Type Name </th>
                                        <th>Is Active? </th>
                                        <th>Action </th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Container.ItemIndex + 1 + "." %></td>
                                <td><%# Eval("rentTypeName") %> </td>
                                <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                                <td>
                                    <asp:Button ID="btnEditRentType" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                        CommandName="EditRentTypeMaster" CommandArgument='<%# Eval("pkRentTypeID") %>' Text="Edit" />
                                    <asp:Button ID="btnDisableRentType" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                        CommandName="DisableRentTypeMaster" CommandArgument='<%# Eval("pkRentTypeID") %>' Text="Disable" />
                                    <asp:Button ID="btnEnableRentType" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                        CommandName="EnableRentTypeMaster" CommandArgument='<%# Eval("pkRentTypeID") %>' Text="Enable" />
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
