using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsPropertyCategory
    {
        protected int _pkPropertyCategoryID;
        protected string _propertyCategoryName;
        protected bool _isActive;
        protected int _createdBy;
        protected DateTime _createdOn;
        public int pkPropertyCategoryID { get { return _pkPropertyCategoryID; } set { _pkPropertyCategoryID = value; } }
        public string propertyCategoryName { get { return _propertyCategoryName; } set { _propertyCategoryName = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
    }
}