using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsLogin
    {
        protected int _pkLoginID;
        protected string _loginUsername;
        protected string _loginPassword;
        protected string _loginSalt;
        protected int _loginRole;
        protected bool _isActive;
        protected bool _isVerified;
        protected DateTime _createdOn;
        public int pkLoginID { get { return _pkLoginID; } set { _pkLoginID = value; } }
        public string loginUsername { get { return _loginUsername; } set { _loginUsername = value; } }
        public string loginPassword { get { return _loginPassword; } set { _loginPassword = value; } }
        public string loginSalt { get { return _loginSalt; } set { _loginSalt = value; } }
        public int loginRole { get { return _loginRole; } set { _loginRole = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public bool isVerified { get { return _isVerified; } set { _isVerified = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
    }
}