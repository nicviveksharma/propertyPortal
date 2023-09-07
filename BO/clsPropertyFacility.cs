using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsPropertyFacility
    {
        protected int _pkPropertyFacilityID;
        protected int _fkPropertyID;
        protected int _fkFacilityID;
        protected double _propertyFacilityDistance;
        public int pkPropertyFacilityID { get { return _pkPropertyFacilityID; } set { _pkPropertyFacilityID = value; } }
        public int fkPropertyID { get { return _fkPropertyID; } set { _fkPropertyID = value; } }
        public int fkFacilityID { get { return _fkFacilityID; } set { _fkFacilityID = value; } }
        public double propertyFacilityDistance { get { return _propertyFacilityDistance; } set { _propertyFacilityDistance = value; } }        
    }
}