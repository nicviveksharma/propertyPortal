using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsPropertyBAL
    {
        public int AddProperty(clsProperty objclsProperty) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyDAL objclsPropertyDAL = new clsPropertyDAL(); // Creating object of Dataccess  
                return objclsPropertyDAL.AddProperty(objclsProperty); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateProperty(clsProperty objclsProperty, int pkPropertyID) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyDAL objclsPropertyDAL = new clsPropertyDAL(); // Creating object of Dataccess  
                return objclsPropertyDAL.UpdateProperty(objclsProperty, pkPropertyID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetProperty(int pkPropertyID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyDAL objclsPropertyDAL = new clsPropertyDAL(); // Creating object of Dataccess  
                return objclsPropertyDAL.GetProperty(pkPropertyID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetPropertyMaster(int pkPropertyID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyDAL objclsPropertyDAL = new clsPropertyDAL(); // Creating object of Dataccess  
                return objclsPropertyDAL.GetPropertyMaster(pkPropertyID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisableProperty(int pkPropertyID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyDAL objclsPropertyDAL = new clsPropertyDAL(); // Creating object of Dataccess  
                return objclsPropertyDAL.EnableDisableProperty(pkPropertyID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}