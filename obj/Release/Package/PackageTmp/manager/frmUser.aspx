<%@ Page Title="" Language="C#" MasterPageFile="~/managerMaster.Master" AutoEventWireup="true" CodeBehind="frmUser.aspx.cs" Inherits="PropertyPortal.manager.frmUser" %>

<%@ Register Src="~/usercontrol/ucUser.ascx" TagPrefix="uc1" TagName="ucUser" %>

<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h3 class="page-title">Add New User</h3>
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                        <li class="breadcrumb-item active" aria-current="page">New User</li>
                    </ol>
                </nav>
            </div>
            <uc1:ucuser runat="server" id="ucUser" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
