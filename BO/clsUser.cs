using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsUser
    {
        protected int _pkUserID;
        protected int _fkLoginID;
        protected string _userFirstName;
        protected string _userMiddleName;
        protected string _userLastName;
        protected string _userEmailAddress;
        protected string _userMobileNo;
        protected string _userCompanyName;
        protected string _userCompanyAddress;
        public int pkUserID { get { return _pkUserID; } set { _pkUserID = value; } }
        public int fkLoginID { get { return _fkLoginID; } set { _fkLoginID = value; } }
        public string userFirstName { get { return _userFirstName; } set { _userFirstName = value; } }
        public string userMiddleName { get { return _userMiddleName; } set { _userMiddleName = value; } }
        public string userLastName { get { return _userLastName; } set { _userLastName = value; } }
        public string userEmailAddress { get { return _userEmailAddress; } set { _userEmailAddress = value; } }
        public string userMobileNo { get { return _userMobileNo; } set { _userMobileNo = value; } }
        public string userCompanyName { get { return _userCompanyName; } set { _userCompanyName = value; } }
        public string userCompanyAddress { get { return _userCompanyAddress; } set { _userCompanyAddress = value; } }
    }
}