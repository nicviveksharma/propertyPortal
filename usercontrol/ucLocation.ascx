<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucLocation.ascx.cs" Inherits="PropertyPortal.usercontrol.ucLocation" %>

<div class="row">
    <asp:Repeater ID="rptLocation" runat="server">
        <HeaderTemplate>
            <div class="owl-carousel location-carousel wow fadeInUp" data-wow-delay="0.1s">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="location-item rounded overflow-hidden">
                <div class="position-relative">
                    <img class="img-fluid" src='data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("imagePath"))%>' alt="">
                </div>
                <div class="text-center p-4 mt-3">
                    <h5 class="fw-bold mb-0"><%#Eval("locationName") %></h5>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</div>
