<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmAllManagers.aspx.cs" Inherits="PropertyPortal.admin.frmAllManagers" %>

<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>
<%@ Register Src="~/usercontrol/ucAllManagers.ascx" TagPrefix="uc1" TagName="ucAllManagers" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h3 class="page-title">All Managers</h3>
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                        <li class="breadcrumb-item active" aria-current="page">All Managers</li>
                    </ol>
                </nav>
            </div>            
            <uc1:ucAllManagers runat="server" ID="ucAllManagers" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>