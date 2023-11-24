<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmManager.aspx.cs" Inherits="PropertyPortal.admin.frmManager" %>

<%@ Register Src="~/usercontrol/ucManager.ascx" TagPrefix="uc1" TagName="ucManager" %>

<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h3 class="page-title">Add New Manager</h3>
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                        <li class="breadcrumb-item active" aria-current="page">New Manager</li>
                    </ol>
                </nav>
            </div>
            <uc1:ucManager runat="server" id="ucManager" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
