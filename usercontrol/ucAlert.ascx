<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAlert.ascx.cs" Inherits="PropertyPortal.usercontrol.ucAlert" %>
<asp:Button ID="btnDummy" CssClass="btn btn-sm" runat="server" Text="" />
<ajaxToolkit:ModalPopupExtender ID="modalStatus" runat="server" TargetControlID="btnDummy"
    PopupControlID="pnlModal" BackgroundCssClass="modalBackground" CancelControlID="btnClose" />
<asp:Panel ID="pnlModal" runat="server" CssClass="modalPopup" Style="display: none;z-index:999999 !important;">
    <div class="col-md-12">
        <div class="alert alert-success" role="alert">
            <h4 class="fw-bold">
                <asp:Label ID="lblAlertHeader" CssClass="fw-bold text-dark" runat="server"></asp:Label></h4>
            <hr>
            <p>
                <asp:Label ID="lblAlertMessage" CssClass="fw-bold text-dark" runat="server"></asp:Label><br />
                <asp:Label ID="lblAlertCustom" CssClass="fw-bold text-dark" runat="server"></asp:Label>
            </p>
            <asp:Button ID="btnClose" CssClass="btn btn-lg btn-danger" runat="server" Text="Close" />
        </div>
    </div>
</asp:Panel>
