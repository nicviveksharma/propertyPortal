<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAllManagers.ascx.cs" Inherits="PropertyPortal.usercontrol.ucAllManagers" %>
<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>
<uc1:ucAlert runat="server" ID="ucAlert" />

<div class="row">
    <div class="col-lg-12 stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">All Users</h4>
                <asp:Repeater ID="rptUser" runat="server">
                    <HeaderTemplate>
                        <table class="table table-bordered sortTable">
                            <thead class="table-dark">
                                <tr>
                                    <th># </th>
                                    <th>User Name</th>
                                    <th>User Email</th>
                                    <th>User Mobile</th>
                                    <th>User Verified</th>
                                    <th>User Active</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Container.ItemIndex + 1 + "." %></td>
                            <td><%# Eval("userFirstName") %>  <%# Eval("userMiddleName") %>  <%# Eval("userLastName") %> </td>
                            <td><%# Eval("loginUsername") %> </td>
                            <td><%# Eval("userMobileNo") %> </td>
                            <td><%# Convert.ToBoolean(Eval("isVerified ")) ? "Yes" : "No" %> </td>
                            <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                            <td>
                                <asp:Button ID="btnEditUser" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                    CommandName="EditUser" CommandArgument='<%# Eval("pkLoginID") %>' Text="Edit" />
                                <asp:Button ID="btnDisableUser" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                    CommandName="DisableUser" CommandArgument='<%# Eval("pkLoginID") %>' Text="Disable" />
                                <asp:Button ID="btnEnableUser" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                    CommandName="EnableUser" CommandArgument='<%# Eval("pkLoginID") %>' Text="Enable" />
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
