<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="PropertyPortal.index" %>

<%@ Register Src="~/usercontrol/ucSearch.ascx" TagPrefix="uc1" TagName="ucSearch" %>

<%@ Register Src="~/usercontrol/ucLocation.ascx" TagPrefix="uc2" TagName="ucLocation" %>
<%@ Register Src="~/usercontrol/ucFeaturedProperties.ascx" TagPrefix="uc3" TagName="ucFeaturedProperties" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
        <ContentTemplate>

            <!-- Header Start -->
            <div class="container-fluid header bg-white p-0">
                <div class="row g-0 align-items-center flex-column-reverse flex-md-row">
                    <div class="col-12 animated fadeIn">
                        <!-- Search Start -->

                        <div class="position-absolute top-50 start-50 bg-light translate-middle" style="z-index: 999;">
                            <uc1:ucSearch runat="server" ID="ucSearch" />
                        </div>

                        <!-- Search End -->
                        <div class="owl-carousel header-carousel">
                            <div class="owl-carousel-item">
                                <img class="img-fluid" src="resources/img/carousel-1.jpg" alt="">
                            </div>
                            <div class="owl-carousel-item">
                                <img class="img-fluid" src="resources/img/carousel-2.jpg" alt="">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Header End -->

            <!-- Featured Start -->
            <div class="container-xxl py-5">
                <div class="container">
                    <div class="row g-0 gx-5 align-items-end">
                        <div class="col-lg-6">
                            <div class="text-start mx-auto mb-5 wow slideInLeft" data-wow-delay="0.1s">
                                <h1 class="mb-3">Featured Properties</h1>
                            </div>
                        </div>
                    </div>
                    <div class="owl-carousel featured-carousel wow fadeInUp" data-wow-delay="0.1s">
                        <div class="featured-item  wow fadeInUp" data-wow-delay="0.1s">
                            <div class="property-item rounded overflow-hidden">
                                <div class="position-relative overflow-hidden">
                                    <a href="">
                                        <img class="img-fluid" src="resources/img/property-1.jpg" alt=""></a>
                                    <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                    <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Appartment</div>
                                </div>
                                <div class="p-4 pb-0">
                                    <h5 class="text-primary mb-3">12,345</h5>
                                    <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                    <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                </div>
                                <div class="d-flex border-top">
                                    <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                    <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                    <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                </div>
                            </div>
                        </div>
                        <div class="featured-item  wow fadeInUp" data-wow-delay="0.3s">
                            <div class="property-item rounded overflow-hidden">
                                <div class="position-relative overflow-hidden">
                                    <a href="">
                                        <img class="img-fluid" src="resources/img/property-2.jpg" alt=""></a>
                                    <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                    <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Villa</div>
                                </div>
                                <div class="p-4 pb-0">
                                    <h5 class="text-primary mb-3">12,345</h5>
                                    <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                    <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                </div>
                                <div class="d-flex border-top">
                                    <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                    <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                    <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                </div>
                            </div>
                        </div>
                        <div class="featured-item  wow fadeInUp" data-wow-delay="0.5s">
                            <div class="property-item rounded overflow-hidden">
                                <div class="position-relative overflow-hidden">
                                    <a href="">
                                        <img class="img-fluid" src="resources/img/property-3.jpg" alt=""></a>
                                    <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                    <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Office</div>
                                </div>
                                <div class="p-4 pb-0">
                                    <h5 class="text-primary mb-3">12,345</h5>
                                    <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                    <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                </div>
                                <div class="d-flex border-top">
                                    <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                    <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                    <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                </div>
                            </div>
                        </div>
                        <div class="featured-item  wow fadeInUp" data-wow-delay="0.1s">
                            <div class="property-item rounded overflow-hidden">
                                <div class="position-relative overflow-hidden">
                                    <a href="">
                                        <img class="img-fluid" src="resources/img/property-4.jpg" alt=""></a>
                                    <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                    <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Building</div>
                                </div>
                                <div class="p-4 pb-0">
                                    <h5 class="text-primary mb-3">12,345</h5>
                                    <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                    <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                </div>
                                <div class="d-flex border-top">
                                    <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                    <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                    <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Featured End -->


            <!-- Location Start -->
            <div class="container-xxl py-5 bg-light">
                <div class="container">
                    <div class="text-center mx-auto mb-5 wow fadeInUp" data-wow-delay="0.1s" style="max-width: 600px;">
                        <h1 class="mb-3">Properties by Location</h1>
                    </div>

                    <div>
                        <uc2:ucLocation runat="server" ID="ucLocation" />
                    </div>
                </div>
            </div>
            <!-- Location End -->


            <!-- Property List Start -->
            <div class="container-xxl py-5">
                <div class="container">
                    <div class="row g-0 gx-5 align-items-end">
                        <div class="col-lg-6">
                            <div class="text-start mx-auto mb-5 wow slideInLeft" data-wow-delay="0.1s">
                                <h1 class="mb-3">Property Listing</h1>
                                <p>Whether you are looking for a cozy apartment, a spacious house, or a commercial space for your business, we have a wide range of properties available for rent and sale.</p>
                            </div>
                        </div>
                        <div class="col-lg-6 text-start text-lg-end wow slideInRight" data-wow-delay="0.1s">
                            <ul class="nav nav-pills d-inline-flex justify-content-end mb-5">
                                <li class="nav-item me-2">
                                    <a class="btn btn-outline-primary active" data-bs-toggle="pill" href="#tab-1">Featured</a>
                                </li>
                                <li class="nav-item me-2">
                                    <a class="btn btn-outline-primary" data-bs-toggle="pill" href="#tab-2">For Sell</a>
                                </li>
                                <li class="nav-item me-0">
                                    <a class="btn btn-outline-primary" data-bs-toggle="pill" href="#tab-3">For Rent</a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class="tab-content">
                        <div id="tab-1" class="tab-pane fade show p-0 active">
                            <div class="row g-4">
                                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.1s">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-1.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Appartment</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.3s">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-2.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Villa</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.5s">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-3.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Office</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.1s">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-4.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Building</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.3s">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-5.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Home</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6 wow fadeInUp" data-wow-delay="0.5s">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-6.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Shop</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-12 text-center wow fadeInUp d-none" data-wow-delay="0.1s">
                                    <a class="btn btn-primary py-3 px-5" href="">Browse More Property</a>
                                </div>
                            </div>
                        </div>
                        <div id="tab-2" class="tab-pane fade show p-0">
                            <div class="row g-4">
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-1.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Appartment</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-2.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Villa</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-3.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Office</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-4.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Building</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-5.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Home</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-6.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Shop</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-12 text-center">
                                    <a class="btn btn-primary py-3 px-5" href="">Browse More Property</a>
                                </div>
                            </div>
                        </div>
                        <div id="tab-3" class="tab-pane fade show p-0">
                            <div class="row g-4">
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-1.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Appartment</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-2.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Villa</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-3.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Office</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-4.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Building</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-5.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Sell</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Home</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4 col-md-6">
                                    <div class="property-item rounded overflow-hidden">
                                        <div class="position-relative overflow-hidden">
                                            <a href="">
                                                <img class="img-fluid" src="resources/img/property-6.jpg" alt=""></a>
                                            <div class="bg-primary rounded text-white position-absolute start-0 top-0 m-4 py-1 px-3">For Rent</div>
                                            <div class="bg-white rounded-top text-primary position-absolute start-0 bottom-0 mx-4 pt-1 px-3">Shop</div>
                                        </div>
                                        <div class="p-4 pb-0">
                                            <h5 class="text-primary mb-3">12,345</h5>
                                            <a class="d-block h5 mb-2" href="">Demo Property Name</a>
                                            <p><i class="fa fa-map-marker-alt text-primary me-2"></i>Mumbai, Maharashtra, India</p>
                                        </div>
                                        <div class="d-flex border-top">
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-ruler-combined text-primary me-2"></i>1000 Sqft</small>
                                            <small class="flex-fill text-center border-end py-2"><i class="fa fa-bed text-primary me-2"></i>3 Bed</small>
                                            <small class="flex-fill text-center py-2"><i class="fa fa-bath text-primary me-2"></i>2 Bath</small>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-12 text-center">
                                    <a class="btn btn-primary py-3 px-5" href="">Browse More Property</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Property List End -->


            <!-- Call to Action Start -->
            <div class="container-xxl py-5">
                <div class="container">
                    <div class="bg-light rounded p-3">
                        <div class="bg-white rounded p-4" style="border: 1px dashed rgba(0, 185, 142, .3)">
                            <div class="row g-5 align-items-center">
                                <div class="col-lg-6 wow fadeIn" data-wow-delay="0.1s">
                                    <img class="img-fluid rounded w-100" src="resources/img/call-to-action.jpg" alt="">
                                </div>
                                <div class="col-lg-6 wow fadeIn" data-wow-delay="0.5s">
                                    <div class="mb-4">
                                        <h1 class="mb-3">Contact Us For Your Real Estate Needs</h1>
                                        <p>Contact us today to explore our extensive property listings and discover the possibilities that await you. We look forward to serving you and being a part of your property success story.</p>
                                    </div>
                                    <a href="" class="btn btn-primary py-3 px-4 me-2"><i class="fa fa-phone-alt me-2"></i>Make A Call</a>
                                    <a href="" class="btn btn-dark py-3 px-4"><i class="fa fa-whatsapp me-2"></i>Whatsapp Us</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Call to Action End -->


            <!-- Team Start -->
            <div class="container-xxl py-5">
                <div class="container">
                    <div class="text-center mx-auto mb-5 wow fadeInUp" data-wow-delay="0.1s" style="max-width: 600px;">
                        <h1 class="mb-3">Property Agents</h1>
                    </div>
                   
                </div>
            </div>
            <!-- Team End -->


            <!-- Testimonial Start -->
            <div class="container-xxl py-5">
                <div class="container">
                    <div class="text-center mx-auto mb-5 wow fadeInUp" data-wow-delay="0.1s" style="max-width: 600px;">
                        <h1 class="mb-3">Our Clients Say!</h1>
                        <p>We look forward to serving you and being a part of your property success story.</p>
                    </div>
                    <div class="owl-carousel testimonial-carousel wow fadeInUp" data-wow-delay="0.1s">
                        <div class="testimonial-item bg-light rounded p-3">
                            <div class="bg-white border rounded p-4">
                                <p>"Working with the Property Dealer has been an absolute pleasure. They understood my requirements perfectly and helped me find the ideal property for my family. Their team was extremely professional, knowledgeable, and proactive throughout the entire process. I highly recommend their services to anyone in search of a reliable and trustworthy real estate partner."</p>
                                <div class="d-flex align-items-center">
                                    <img class="img-fluid flex-shrink-0 rounded" src="resources/img/testimonial-3.jpg" style="width: 45px; height: 45px;">
                                    <div class="ps-3">
                                        <h6 class="fw-bold mb-1">Rajesh Kumar</h6>
                                        <small>Homebuyer</small>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="testimonial-item bg-light rounded p-3">
                            <div class="bg-white border rounded p-4">
                                <p>"I cannot thank the Property Dealer enough for their exceptional service. As a first-time tenant, I was apprehensive about finding the right rental property. However, their team guided me with patience and professionalism, showing me various options within my budget. They assisted me throughout the documentation process and ensured a seamless move-in experience. I would gladly recommend their services to anyone seeking quality rental properties."</p>
                                <div class="d-flex align-items-center">
                                    <img class="img-fluid flex-shrink-0 rounded" src="resources/img/testimonial-2.jpg" style="width: 45px; height: 45px;">
                                    <div class="ps-3">
                                        <h6 class="fw-bold mb-1">Sameer Gupta</h6>
                                        <small>Tenant</small>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="testimonial-item bg-light rounded p-3">
                            <div class="bg-white border rounded p-4">
                                <p>"I had been struggling to find a suitable commercial space for my business until I came across the Property Dealer. Their team went above and beyond to understand my business needs and provided me with multiple options that fit my requirements. Their expertise and attention to detail made the entire leasing process smooth and hassle-free. I am grateful for their support and highly recommend them to anyone looking for commercial properties."</p>
                                <div class="d-flex align-items-center">
                                    <img class="img-fluid flex-shrink-0 rounded" src="resources/img/testimonial-1.jpg" style="width: 45px; height: 45px;">
                                    <div class="ps-3">
                                        <h6 class="fw-bold mb-1">Priya Singh</h6>
                                        <small>Business Owner</small>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Testimonial End -->
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="ucSearch" />
            <asp:PostBackTrigger ControlID="ucLocation" />
            <asp:PostBackTrigger ControlID="ucFeaturedProperties" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
