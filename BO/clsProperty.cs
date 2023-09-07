using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsProperty
    {
        protected int _pkPropertyID;
        protected int _fkStateID;
        protected int _fkDistrictID;
        protected int _fkCityID;
        protected int _fkPropertyCategoryID;
        protected int _fkPropertyTypeID;
        protected int _fkRentTypeID;
        protected int _fkOwnerUserID;
        protected string _propertyTitle;
        protected string _propertyShortTitle;
        protected string _propertyLink;
        protected string _propertyShortDescription;
        protected string _propertyLongDescription;
        protected string _propertyLatitude;
        protected string _propertyLongitude;
        protected string _propertyAddress;
        protected int _propertyTotalFloor;
        protected int _propertyTotalBedroom;
        protected int _propertyTotalBathroom;
        protected string _propertyArea;
        protected double _propertyPrice;
        protected string _propertyYoutubeLink;
        protected string _propertySEOTitle;
        protected string _propertySEODescription;
        protected bool _isFeatured;
        protected bool _isActive;
        protected bool _isVerified;
        protected int _createdBy;
        protected DateTime _createdOn;
        protected int _modifiedBy;
        protected DateTime _modifiedOn;
        protected int _verifiedBy;
        protected DateTime _verifiedOn;

        public int pkPropertyID { get { return _pkPropertyID; } set { _pkPropertyID = value; } }
        public int fkStateID { get { return _fkStateID; } set { _fkStateID = value; } }
        public int fkDistrictID { get { return _fkDistrictID; } set { _fkDistrictID = value; } }
        public int fkCityID { get { return _fkCityID; } set { _fkCityID = value; } }
        public int fkPropertyCategoryID { get { return _fkPropertyCategoryID; } set { _fkPropertyCategoryID = value; } }
        public int fkPropertyTypeID { get { return _fkPropertyTypeID; } set { _fkPropertyTypeID = value; } }
        public int fkRentTypeID { get { return _fkRentTypeID; } set { _fkRentTypeID = value; } }
        public int fkOwnerUserID { get { return _fkOwnerUserID; } set { _fkOwnerUserID = value; } }
        public string propertyTitle { get { return _propertyTitle; } set { _propertyTitle = value; } }
        public string propertyShortTitle { get { return _propertyShortTitle; } set { _propertyShortTitle = value; } }
        public string propertyLink { get { return _propertyLink; } set { _propertyLink = value; } }
        public string propertyShortDescription { get { return _propertyShortDescription; } set { _propertyShortDescription = value; } }
        public string propertyLongDescription { get { return _propertyLongDescription; } set { _propertyLongDescription = value; } }
        public string propertyLatitude { get { return _propertyLatitude; } set { _propertyLatitude = value; } }
        public string propertyLongitude { get { return _propertyLongitude; } set { _propertyLongitude = value; } }
        public string propertyAddress { get { return _propertyAddress; } set { _propertyAddress = value; } }
        public int propertyTotalFloor { get { return _propertyTotalFloor; } set { _propertyTotalFloor = value; } }
        public int propertyTotalBedroom { get { return _propertyTotalBedroom; } set { _propertyTotalBedroom = value; } }
        public int propertyTotalBathroom { get { return _propertyTotalBathroom; } set { _propertyTotalBathroom = value; } }
        public string propertyArea { get { return _propertyArea; } set { _propertyArea = value; } }
        public double propertyPrice { get { return _propertyPrice; } set { _propertyPrice = value; } }
        public string propertyYoutubeLink { get { return _propertyYoutubeLink; } set { _propertyYoutubeLink = value; } }
        public string propertySEOTitle { get { return _propertySEOTitle; } set { _propertySEOTitle = value; } }
        public string propertySEODescription { get { return _propertySEODescription; } set { _propertySEODescription = value; } }
        public bool isFeatured { get { return _isFeatured; } set { _isFeatured = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public bool isVerified { get { return _isVerified; } set { _isVerified = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
        public int modifiedBy { get { return _modifiedBy; } set { _modifiedBy = value; } }
        public DateTime modifiedOn { get { return _modifiedOn; } set { _modifiedOn = value; } }
        public int verifiedBy { get { return _verifiedBy; } set { _verifiedBy = value; } }
        public DateTime verifiedOn { get { return _verifiedOn; } set { _verifiedOn = value; } }
    }
}