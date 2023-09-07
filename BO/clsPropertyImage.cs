using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsPropertyImage
    {
        protected int _pkPropertyImage;
        protected int _fkPropertyID;
        protected byte[] _propertyImage;
        protected bool _isFeaturedImage;
        protected bool _isBannerImage;
        public int pkPropertyImage { get { return _pkPropertyImage; } set { _pkPropertyImage = value; } }
        public int fkPropertyID { get { return _fkPropertyID; } set { _fkPropertyID = value; } }
        public byte[] propertyImage { get { return _propertyImage; } set { _propertyImage = value; } }
        public bool isFeaturedImage { get { return _isFeaturedImage; } set { _isFeaturedImage = value; } }
        public bool isBannerImage { get { return _isBannerImage; } set { _isBannerImage = value; } }
    }
}