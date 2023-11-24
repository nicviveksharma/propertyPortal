<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAllProperties.ascx.cs" Inherits="PropertyPortal.usercontrol.ucAllProperties" %>
<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>

<div class="row">
    <uc1:ucAlert runat="server" ID="ucAlert" />
</div>
<div class="row">
    <div class="col-lg-12 stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">All Properties</h4>
                <asp:Repeater ID="rptProperty" runat="server">
                    <HeaderTemplate>
                        <table class="table table-bordered sortTable">
                            <thead class="table-dark">
                                <tr>
                                    <th># </th>
                                    <th>Property Name </th>
                                    <th>Is Active? </th>
                                    <th>Action </th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Container.ItemIndex + 1 + "." %></td>
                            <td><%# Eval("propertyTitle") %> </td>
                            <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                            <td>
                                <asp:Button ID="btnEditProperty" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                    CommandName="EditPropertyMaster" CommandArgument='<%# Eval("pkPropertyID") %>' Text="Edit" />
                                <asp:Button ID="btnDisableProperty" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                    CommandName="DisablePropertyMaster" CommandArgument='<%# Eval("pkPropertyID") %>' Text="Disable" />
                                <asp:Button ID="btnEnableProperty" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                    CommandName="EnablePropertyMaster" CommandArgument='<%# Eval("pkPropertyID") %>' Text="Enable" />
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
