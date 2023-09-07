using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsRentType
    {
        protected int _pkRentTypeID;
        protected string _rentTypeName;
        protected bool _isActive;
        protected int _createdBy;
        protected DateTime _createdOn;
        public int pkRentTypeID { get { return _pkRentTypeID; } set { _pkRentTypeID = value; } }
        public string rentTypeName { get { return _rentTypeName; } set { _rentTypeName = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
    }
}