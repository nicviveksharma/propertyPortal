using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsPropertyTypeBAL
    {
        public int AddPropertyTypeMaster(clsPropertyType objclsPropertyType) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyTypeDAL objclsPropertyTypeDAL = new clsPropertyTypeDAL(); // Creating object of Dataccess  
                return objclsPropertyTypeDAL.AddPropertyTypeMaster(objclsPropertyType); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdatePropertyTypeMaster(clsPropertyType objclsPropertyType, int pkPropertyTypeID) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyTypeDAL objclsPropertyTypeDAL = new clsPropertyTypeDAL(); // Creating object of Dataccess  
                return objclsPropertyTypeDAL.UpdatePropertyTypeMaster(objclsPropertyType, pkPropertyTypeID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetPropertyTypeMaster(int pkPropertyTypeID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyTypeDAL objclsPropertyTypeDAL = new clsPropertyTypeDAL(); // Creating object of Dataccess  
                return objclsPropertyTypeDAL.GetPropertyTypeMaster(pkPropertyTypeID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisablePropertyTypeMaster(int pkPropertyTypeID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyTypeDAL objclsPropertyTypeDAL = new clsPropertyTypeDAL(); // Creating object of Dataccess  
                return objclsPropertyTypeDAL.EnableDisablePropertyTypeMaster(pkPropertyTypeID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}