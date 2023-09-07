using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsState
    {
        protected int _pkStateID;
        protected string _stateName;
        protected bool _isActive;
        protected int _createdBy;
        protected DateTime _createdOn;
        public int pkStateID { get { return _pkStateID; } set { _pkStateID = value; } }
        public string stateName { get { return _stateName; } set { _stateName = value; } }
        public bool isActive { get { return _isActive; } set { _isActive = value; } }
        public int createdBy { get { return _createdBy; } set { _createdBy = value; } }
        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value; } }
    }
}