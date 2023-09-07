using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsPropertyCategoryBAL
    {
        public int AddPropertyCategoryMaster(clsPropertyCategory objclsPropertyCategory) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyCategoryDAL objclsPropertyCategoryDAL = new clsPropertyCategoryDAL(); // Creating object of Dataccess  
                return objclsPropertyCategoryDAL.AddPropertyCategoryMaster(objclsPropertyCategory); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdatePropertyCategoryMaster(clsPropertyCategory objclsPropertyCategory, int pkPropertyCategoryID) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyCategoryDAL objclsPropertyCategoryDAL = new clsPropertyCategoryDAL(); // Creating object of Dataccess  
                return objclsPropertyCategoryDAL.UpdatePropertyCategoryMaster(objclsPropertyCategory, pkPropertyCategoryID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetPropertyCategoryMaster(int pkPropertyCategoryID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyCategoryDAL objclsPropertyCategoryDAL = new clsPropertyCategoryDAL(); // Creating object of Dataccess  
                return objclsPropertyCategoryDAL.GetPropertyCategoryMaster(pkPropertyCategoryID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisablePropertyCategoryMaster(int pkPropertyCategoryID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyCategoryDAL objclsPropertyCategoryDAL = new clsPropertyCategoryDAL(); // Creating object of Dataccess  
                return objclsPropertyCategoryDAL.EnableDisablePropertyCategoryMaster(pkPropertyCategoryID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}