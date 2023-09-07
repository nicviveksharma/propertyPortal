using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsPropertyFeature
    {
        protected int _pkPropertyFeatureID;
        protected int _fkPropertyID;
        protected int _fkFeatureID;
        public int pkPropertyFeatureID { get { return _pkPropertyFeatureID; } set { _pkPropertyFeatureID = value; } }
        public int fkPropertyID { get { return _fkPropertyID; } set { _fkPropertyID = value; } }
        public int fkFeatureID { get { return _fkFeatureID; } set { _fkFeatureID = value; } }
    }
}