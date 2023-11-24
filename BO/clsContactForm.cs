using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyPortal.BO
{
    public class clsContactForm
    {
        protected int _ip;

        protected string _name;    

        protected string _email;    

        protected string _phone;    

        protected string _address;  

        protected string _message;

        protected DateTime _createdOn;

        public string name { get { return _name; } set { _name = value; } } 

        public string email { get { return _email; } set { _email = value; } }

        public string phone { get { return _phone; } set { _phone = value; } }

        public String address { get { return _address; } set { _address = value; } }

        public string message { get { return _message; } set { _message = value; } }

        public int ip { get { return _ip; } set { _ip = value; } }

        public DateTime createdOn { get { return _createdOn; } set { _createdOn = value;} }

        


    }
}