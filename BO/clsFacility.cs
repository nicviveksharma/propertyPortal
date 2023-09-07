using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsFacility
    {
        protected int _pkFacilityID;
        protected string _facilityName;
        protected bool _isActive;
        protected int _createdBy;
        protected DateTime _createdOn;
        public int pkFacilityID { get { return _pkFacilityID; } set { _pkFacilityID = value; } }
        public string facilityName { get { return _facilityName; } set { _facilityName = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
    }
}