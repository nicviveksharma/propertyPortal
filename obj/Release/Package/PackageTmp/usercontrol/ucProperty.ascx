<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucProperty.ascx.cs" Inherits="PropertyPortal.usercontrol.ucProperty" %>
<%@ Register Src="~/usercontrol/ucAlert.ascx" TagPrefix="uc1" TagName="ucAlert" %>

<div class="row">
    <uc1:ucAlert runat="server" ID="ucAlert" />
</div>
<div class="row">
    <div class="col-md-8 grid-margin ">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">Basic Details</h4>
                <div class="forms-sample">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="txtPropertyTitle">Property Title:</label>
                            <asp:TextBox ID="txtPropertyTitle" CssClass="form-control form-control-sm" runat="server" placeholder="Property Title" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtPropertyTitle" runat="server" ControlToValidate="txtPropertyTitle" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="txtPropertyShortTitle">Property Short Title:</label>
                            <asp:TextBox ID="txtPropertyShortTitle" CssClass="form-control form-control-sm" runat="server" placeholder="Property Short Title" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtPropertyShortTitle" runat="server" ControlToValidate="txtPropertyShortTitle" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="txtPropertyLink">Property Link:</label>
                            <asp:TextBox ID="txtPropertyLink" CssClass="form-control form-control-sm" runat="server" placeholder="Property Link" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtPropertyLink" runat="server" ControlToValidate="txtPropertyLink" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="txtPropertyShortDescription">Property Short Description:</label>
                            <asp:TextBox ID="txtPropertyShortDescription" TextMode="MultiLine" Rows="4" CssClass="form-control form-control-sm" runat="server" placeholder="Property Short Description" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtPropertyShortDescription" runat="server" ControlToValidate="txtPropertyShortDescription" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="txtPropertyLongDescription">Content:</label>
                            <asp:TextBox ID="txtPropertyLongDescription" TextMode="MultiLine" Rows="8" CssClass="form-control form-control-sm" runat="server" placeholder="Content" ValidationGroup="validate"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reqtxtPropertyLongDescription" runat="server" ControlToValidate="txtPropertyLongDescription" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="card mt-2">
            <div class="card-body">
                <h4 class="card-title">Image Gallery</h4>

            </div>
        </div>
        <div class="card mt-2">
            <div class="card-body">
                <h4 class="card-title">Demographic Details</h4>
                <div class="forms-sample">
                    <div class="row">
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="drpState">State:</label>
                                <asp:DropDownList ID="drpState" CssClass="form-control form-control-sm" runat="server" ValidationGroup="validate" AutoPostBack="true" OnSelectedIndexChanged="drpState_SelectedIndexChanged"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="reqdrpState" runat="server" ControlToValidate="drpState" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="drpDistrict">District:</label>
                                <asp:DropDownList ID="drpDistrict" CssClass="form-control form-control-sm" runat="server" ValidationGroup="validate" AutoPostBack="true" OnSelectedIndexChanged="drpDistrict_SelectedIndexChanged"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="reqdrpDistrict" runat="server" ControlToValidate="drpDistrict" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="form-group">
                                <label for="drpCity">City:</label>
                                <asp:DropDownList ID="drpCity" CssClass="form-control form-control-sm" runat="server" ValidationGroup="validate"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="reqdrpCity" runat="server" ControlToValidate="drpCity" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="form-group">
                                <label for="txtPropertyAddress">Property Address:</label>
                                <asp:TextBox ID="txtPropertyAddress" TextMode="MultiLine" Rows="3" CssClass="form-control form-control-sm" runat="server"
                                    placeholder="Property Address" ValidationGroup="validate"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtPropertyAddress" runat="server" ControlToValidate="txtPropertyAddress" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="txtPropertyLatitude">Property Latitude:</label>
                                <asp:TextBox ID="txtPropertyLatitude" CssClass="form-control form-control-sm" runat="server" placeholder="Property Latitude" ValidationGroup="validate"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtPropertyLatitude" runat="server" ControlToValidate="txtPropertyLatitude" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="txtPropertyLongitude">Property Longitude:</label>
                                <asp:TextBox ID="txtPropertyLongitude" CssClass="form-control form-control-sm" runat="server" placeholder="Property Longitude" ValidationGroup="validate"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtPropertyLongitude" runat="server" ControlToValidate="txtPropertyLongitude" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="card mt-2">
            <div class="card-body">
                <h4 class="card-title">Other Details</h4>
                <div class="forms-sample">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="txtPropertyTotalFloor">Total Floor:</label>
                                <asp:TextBox ID="txtPropertyTotalFloor" TextMode="Number" CssClass="form-control form-control-sm" runat="server" placeholder="Total Floor" ValidationGroup="validate"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtPropertyTotalFloor" runat="server" ControlToValidate="txtPropertyTotalFloor" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="txtPropertyTotalBedroom">Total Bedroom:</label>
                                <asp:TextBox ID="txtPropertyTotalBedroom" TextMode="Number" CssClass="form-control form-control-sm" runat="server" placeholder="Total Bedroom" ValidationGroup="validate"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtPropertyTotalBedroom" runat="server" ControlToValidate="txtPropertyTotalBedroom" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="txtPropertyTotalBathroom">Total Bathroom:</label>
                                <asp:TextBox ID="txtPropertyTotalBathroom" TextMode="Number" CssClass="form-control form-control-sm" runat="server" placeholder="Total Bathroom" ValidationGroup="validate"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtPropertyTotalBathroom" runat="server" ControlToValidate="txtPropertyTotalBathroom" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="txtPropertyArea">Area (sq. ft.):</label>
                                <asp:TextBox ID="txtPropertyArea" TextMode="Number" CssClass="form-control form-control-sm" runat="server" placeholder="Area" ValidationGroup="validate"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtPropertyArea" runat="server" ControlToValidate="txtPropertyArea" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <label for="txtPropertyPrice">Price (INR):</label>
                                <asp:TextBox ID="txtPropertyPrice" TextMode="Number" CssClass="form-control form-control-sm" runat="server" placeholder="Price" ValidationGroup="validate"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="reqtxtPropertyPrice" runat="server" ControlToValidate="txtPropertyPrice" Display="Dynamic"
                                    ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="card mt-2">
            <div class="card-body">
                <h4 class="card-title">Distance from Important Locations</h4>
                <div class="forms-sample">
                    <div class="form-group">
                        <asp:Repeater ID="rptFacilities" runat="server">
                            <HeaderTemplate>
                                <table class="table table-sm table-striped table-bordered">
                            </HeaderTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblpkFacilityID" Visible="false" Text='<%#Eval("pkFacilityID") %>' runat="server"></asp:Label>
                                        <asp:Label ID="lblFacilityName" Text='<%#Eval("facilityName") %>' runat="server"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="txtFacilityDistance" runat="server" TextMode="Number"></asp:TextBox>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </div>

                </div>
            </div>
        </div>
        <div class="card mt-2">
            <div class="card-body">
                <h4 class="card-title">Video Link & SEO Details</h4>
                <div class="forms-sample">
                    <div class="form-group">
                        <label for="txtPropertyYoutubeLink">Youtube Link:</label>
                        <asp:TextBox ID="txtPropertyYoutubeLink" CssClass="form-control form-control-sm" runat="server" placeholder="Yotube Link" ValidationGroup="validate"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqtxtPropertyYoutubeLink" runat="server" ControlToValidate="txtPropertyYoutubeLink" Display="Dynamic"
                            ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="txtPropertySEOTitle">SEO Title:</label>
                        <asp:TextBox ID="txtPropertySEOTitle" CssClass="form-control form-control-sm" runat="server" placeholder="SEO Title" ValidationGroup="validate"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPropertySEOTitle" Display="Dynamic"
                            ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="txtPropertySEODescription">SEO Description:</label>
                        <asp:TextBox ID="txtPropertySEODescription" TextMode="MultiLine" Rows="3" CssClass="form-control form-control-sm" runat="server" placeholder="SEO Description" ValidationGroup="validate"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reqtxtPropertySEODescription" runat="server" ControlToValidate="txtPropertySEODescription" Display="Dynamic"
                            ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <div class="col-md-4 grid-margin">
        <div class="card">
            <div class="card-body">
                <div class="forms-sample">
                    <div class="form-check form-check-flat form-check-primary">
                        <span class="form-check-label">
                            <asp:CheckBox ID="chkIsFeatured" runat="server" ValidationGroup="validate" />
                            Is Featured? <i class="input-helper"></i>
                        </span>
                    </div>
                    <div class="form-check form-check-flat form-check-primary">
                        <span class="form-check-label">
                            <asp:CheckBox ID="chkIsActive" runat="server" ValidationGroup="validate" />
                            Is Active? <i class="input-helper"></i>
                        </span>
                    </div>
                </div>
            </div>
        </div>

        <div class="card mt-2">
            <div class="card-body">
                <div class="forms-sample">
                    <div class="col-md-12">
                        <div class="form-group">
                            <label for="drpPropertyCategory">Featured Image:</label>
                            <asp:FileUpload ID="fileuploadcustom" ClientIDMode="Static" CssClass="form-control" runat="server" onchange="loadImageFile();"></asp:FileUpload>
                            <asp:RequiredFieldValidator ID="reqfileuploadcustom" Display="Dynamic" ErrorMessage="* - Required" CssClass="text-danger" runat="server" ControlToValidate="fileuploadcustom" ValidationGroup="error"></asp:RequiredFieldValidator>
                            <img id="imgpreview" runat="server" class="zoom" />
                            <asp:HiddenField ID="hidimagefile" runat="server" ClientIDMode="Static" />
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="card mt-2">
            <div class="card-body">
                <div class="forms-sample">

                    <div class="form-group">
                        <label for="drpPropertyCategory">Property Category:</label>
                        <asp:DropDownList ID="drpPropertyCategory" CssClass="form-control form-control-sm" runat="server" ValidationGroup="validate"
                            AutoPostBack="true" OnSelectedIndexChanged="drpPropertyCategory_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="reqdrpPropertyCategory" runat="server" ControlToValidate="drpPropertyCategory" Display="Dynamic"
                            ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="drpPropertyType">Property Type:</label>
                        <asp:DropDownList ID="drpPropertyType" CssClass="form-control form-control-sm" runat="server" ValidationGroup="validate"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="reqdrpPropertyType" runat="server" ControlToValidate="drpPropertyType" Display="Dynamic"
                            ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                    </div>

                    <div class="form-group">
                        <asp:Panel ID="pnlPropertyRentType" Visible="false" runat="server">
                            <label for="drpRentType">Rent Type:</label>
                            <asp:DropDownList ID="drpRentType" CssClass="form-control form-control-sm" runat="server" ValidationGroup="validate"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="reqdrpRentType" runat="server" ControlToValidate="drpRentType" Display="Dynamic"
                                ErrorMessage="* - Required" CssClass="text-danger text-small fw-bold" ValidationGroup="validate"></asp:RequiredFieldValidator>
                        </asp:Panel>
                    </div>
                </div>
            </div>
        </div>
        <div class="card mt-2">
            <div class="card-body">
                <div class="forms-sample">
                    <div class="form-group">
                        <asp:CheckBoxList ID="chkPropertyFeature" runat="server" RepeatDirection="Vertical"></asp:CheckBoxList>
                    </div>

                </div>
            </div>
        </div>

        <div class="card mt-2">
            <div class="card-body">
                <div class="forms-sample">
                    <div class="form-group">
                        <asp:HiddenField ID="hidpkPropertyID" runat="server" />
                        <asp:Button ID="btnAddProperty" CssClass="btn btn-gradient-primary me-2" runat="server" Text="Save" OnClick="btnAddProperty_Click"
                            ValidationGroup="validate" />
                        <asp:Button ID="btnUpdateProperty" CssClass="btn btn-gradient-secondary me-2" runat="server" Text="Update" OnClick="btnUpdateProperty_Click"
                            ValidationGroup="validate" Visible="false" />
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
<div class="row">
    <div class="col-lg-12 stretch-card">
        <div class="card">
            <div class="card-body">
                <h4 class="card-title">All Properties</h4>
                <asp:Repeater ID="rptProperty" runat="server">
                    <HeaderTemplate>
                        <table class="table table-bordered sortTable">
                            <thead class="table-dark">
                                <tr>
                                    <th># </th>
                                    <th>Property Name </th>
                                    <th>Is Active? </th>
                                    <th>Action </th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Container.ItemIndex + 1 + "." %></td>
                            <td><%# Eval("stateName") %> </td>
                            <td><%# Convert.ToBoolean(Eval("isActive")) ? "Yes" : "No" %> </td>
                            <td>
                                <asp:Button ID="btnEditProperty" runat="server" CssClass="btn btn-sm btn-gradient-warning"
                                    CommandName="EditPropertyMaster" CommandArgument='<%# Eval("pkPropertyID") %>' Text="Edit" />
                                <asp:Button ID="btnDisableProperty" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? true : false %>' runat="server" CssClass="btn btn-sm btn-gradient-danger"
                                    CommandName="DisablePropertyMaster" CommandArgument='<%# Eval("pkPropertyID") %>' Text="Disable" />
                                <asp:Button ID="btnEnableProperty" Visible='<%# Convert.ToBoolean(Eval("isActive")) ? false : true %>' runat="server" CssClass="btn btn-sm btn-gradient-info"
                                    CommandName="EnablePropertyMaster" CommandArgument='<%# Eval("pkPropertyID") %>' Text="Enable" />
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                            </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</div>
