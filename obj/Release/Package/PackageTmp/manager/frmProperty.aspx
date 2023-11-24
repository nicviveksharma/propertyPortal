<%@ Page Language="C#" MasterPageFile="~/managerMaster.Master" AutoEventWireup="true" CodeBehind="frmProperty.aspx.cs" Inherits="PropertyPortal.manager.frmProperty" %>

<%@ Register Src="~/usercontrol/ucProperty.ascx" TagPrefix="uc1" TagName="ucProperty" %>

<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../assets/js/imagecompress.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h3 class="page-title">Add New Property</h3>
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                        <li class="breadcrumb-item active" aria-current="page">New Property</li>
                    </ol>
                </nav>
            </div>
            <uc1:ucProperty runat="server" ID="ucProperty" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>