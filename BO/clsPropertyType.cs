using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsPropertyType
    {
        protected int _pkPropertyTypeID;
        protected string _propertyTypeName;
        protected bool _isActive;
        protected int _createdBy;
        protected DateTime _createdOn;
        public int pkPropertyTypeID { get { return _pkPropertyTypeID; } set { _pkPropertyTypeID = value; } }
        public string propertyTypeName { get { return _propertyTypeName; } set { _propertyTypeName = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
    }
}