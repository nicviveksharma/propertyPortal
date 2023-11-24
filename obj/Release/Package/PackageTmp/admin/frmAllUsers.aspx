<%@ Page Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="frmAllUsers.aspx.cs" Inherits="PropertyPortal.admin.frmAllUsers" %>

<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>
<%@ Register Src="~/usercontrol/ucAllUsers.ascx" TagPrefix="uc1" TagName="ucAllUsers" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="page-header">
                <h3 class="page-title">All Agents</h3>
                <nav aria-label="breadcrumb">
                    <ol class="breadcrumb">
                        <li class="breadcrumb-item"><a href="#">Dashboard</a></li>
                        <li class="breadcrumb-item active" aria-current="page">All Agents</li>
                    </ol>
                </nav>
            </div>            
            <uc1:ucAllUsers runat="server" ID="ucAllUsers" />
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>