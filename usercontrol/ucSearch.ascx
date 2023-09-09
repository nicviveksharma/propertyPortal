<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucSearch.ascx.cs" Inherits="PropertyPortal.usercontrol.ucSearch" %>
<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>


<!-- Search Start -->
<div class="row g-3 p-4">
    <div class="col-sm">
        <asp:DropDownList ID="drpPropertyCategory" CssClass="form-select" runat="server"></asp:DropDownList>
    </div>
    <div class="col-sm">
        <asp:DropDownList ID="drpPropertyType" CssClass="form-select" runat="server"></asp:DropDownList>
    </div>
    <div class="col-sm">
        <asp:TextBox class="form-control" runat="server" id="txtPropertylocation" placeholder="Location" aria-label="Location" ></asp:TextBox>
    </div>
    <div class="col-sm">
        <asp:Button ID="btnSearch" runat="server" class="btn btn-primary px-5" Text="Search" />
    </div>
    <a data-bs-toggle="collapse" data-bs-target="#advancesearch" aria-expanded="false" aria-controls="advancesearch">Advance Search</a>
</div>
<div class="row collapse m-2" id="advancesearch">
    <div class="col-sm">
        <asp:DropDownList ID="drpCity" CssClass="form-select" runat="server"></asp:DropDownList>
    </div>
    <div class="col-sm">
        <asp:DropDownList ID="drpBedroomcount" runat="server" class="form-select">
            <asp:ListItem Selected="True" Value="-1" Text="--No. of Bedroom--"></asp:ListItem>
            <asp:ListItem Value="1" Text="1"></asp:ListItem>
            <asp:ListItem Value="2" Text="2"></asp:ListItem>
            <asp:ListItem Value="3" Text="3"></asp:ListItem>
            <asp:ListItem Value="4" Text="4"></asp:ListItem>
            <asp:ListItem Value="5" Text="5"></asp:ListItem>
        </asp:DropDownList>

    </div>
    <div class="col-sm">
        <asp:DropDownList ID="drpBathroomcount" runat="server" class="form-select">
            <asp:ListItem Selected="True" Value="-1" Text="--No. of Bathroom--"></asp:ListItem>
            <asp:ListItem Value="1" Text="1"></asp:ListItem>
            <asp:ListItem Value="2" Text="2"></asp:ListItem>
            <asp:ListItem Value="3" Text="3"></asp:ListItem>
            <asp:ListItem Value="4" Text="4"></asp:ListItem>
            <asp:ListItem Value="5" Text="5"></asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="col-sm">
        <asp:TextBox ID="txtPropertyArea" TextMode="Number" CssClass="form-control" runat="server" min="0" placeholder="Area" ></asp:TextBox>
    </div>
</div>

<!-- Search End -->
