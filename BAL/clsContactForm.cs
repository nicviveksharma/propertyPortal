using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsContactFormBAL
    {
        public int AddContactForm(clsContactForm objclsContactForm) // passing Bussiness object Here  
        {
            try
            {
                clsContactFormDAL objclsContactFormDAL = new clsContactFormDAL(); // Creating object of Dataccess  
                return objclsContactFormDAL.AddContactFormDAL(objclsContactForm); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}