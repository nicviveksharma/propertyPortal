using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsCity
    {
        protected int _pkCityID;
        protected int _fkDistrictID;
        protected string _cityName;
        protected bool _isActive;
        protected int _createdBy;
        protected DateTime _createdOn;
        public int pkCityID { get { return _pkCityID; } set { _pkCityID = value; } }
        public int fkDistrictID { get { return _fkDistrictID; } set { _fkDistrictID = value; } }
        public string cityName { get { return _cityName; } set { _cityName = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }

    }
}