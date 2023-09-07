using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsFeature
    {
        protected int _pkFeatureID;
        protected string _featureName;
        protected bool _isActive;
        protected int _createdBy;
        protected DateTime _createdOn;
        public int pkFeatureID { get { return _pkFeatureID; } set { _pkFeatureID = value; } }
        public string featureName { get { return _featureName; } set { _featureName = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
    }
}