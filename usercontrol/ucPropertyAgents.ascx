<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucPropertyAgents.ascx.cs" Inherits="PropertyPortal.usercontrol.ucPropertyAgents" %>
<div class="row g-4">

    <asp:Repeater ID="rptPropertyAgents" runat="server">
        <HeaderTemplate>
            <div class="featured-item  wow fadeInUp" data-wow-delay="0.1s">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="team-item rounded overflow-hidden">
                <div class="position-relative">
                    <img class="img-fluid" src='data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("imagePath"))%>' alt="">
                </div>
                <div class="text-center p-4 mt-3">
                    <h5 class="fw-bold mb-0"><%#Eval("agentname") %></h5>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</div>
