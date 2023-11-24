<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmAllProperties.aspx.cs" Inherits="PropertyPortal.admin.frmAllProperties" %>

<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>
<%@ Register Src="~/usercontrol/ucAllProperties.ascx" TagPrefix="uc1" TagName="ucAllProperties" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../assets/js/imagecompress.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h3 class="page-title">All Properties</h3>
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                        <li class="breadcrumb-item active" aria-current="page">All Properties</li>
                    </ol>
                </nav>
            </div>
            <uc1:ucAllProperties runat="server" ID="ucAllProperties" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>