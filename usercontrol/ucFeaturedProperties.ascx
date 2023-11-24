<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucFeaturedProperties.ascx.cs" Inherits="PropertyPortal.usercontrol.ucFeaturedProperties" %>

<div class="row">
    <asp:Repeater ID="rptFeaturedProperties" runat="server">
        <HeaderTemplate>
            <div class="featured-item  wow fadeInUp" data-wow-delay="0.1s">
        </HeaderTemplate>
        <ItemTemplate>
            <%--<itemtemplate>
                <% if (Condition){ %>Show this line<%} %>
            </itemtemplate>--%>
            <div class="position-relative overflow-hidden">
                <a href="#!">
                    <img class="img-fluid" src='data:image/png;base64,<%# Convert.ToBase64String((byte[])Eval("imagePath"))%>' alt="">
                </a>
                <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3"><%#Eval("propertyCategoryName") %></div>
                <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3"><%#Eval("propertyTypeName") %></div>
            </div>
            <div class="p-4 pb-0">
                <h5 class="text-primary mb-3"><%#Eval("propertyPrice") %></h5>
                <a class="d-block h5 mb-2" href="#!"><%#Eval("propertyTitle") %></a>
                <p><i class="fa fa-map-marker-alt text-primary me-2"></i><%#Eval("locationName") %></p>
            </div>
            <div class="d-flex border-top">
                <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i><%#Eval("propertyArea") %>Sqft</small>
                <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i><%#Eval("propertyTotalBedroom") %> Bed</small>
                <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i><%#Eval("propertyTotalBathroom") %> Bath</small>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:Repeater>
</div>
