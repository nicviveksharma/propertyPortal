
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsDistrict
    {
        protected int _pkDistrictID;
        protected int _fkStateID;
        protected string _districtName;
        protected bool _isActive;
        protected int _createdBy;
        protected DateTime _createdOn;
        public int pkDistrictID { get { return _pkDistrictID; } set { _pkDistrictID = value; } }
        public int fkStateID { get { return _fkStateID; } set { _fkStateID = value; } }
        public string districtName { get { return _districtName; } set { _districtName = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
    }
}