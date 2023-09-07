using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsPropertyFeatureBAL
    {
        public int AddPropertyFeature(clsPropertyFeature objclsPropertyFeature) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyFeatureDAL objclsPropertyFeatureDAL = new clsPropertyFeatureDAL(); // Creating object of Dataccess  
                return objclsPropertyFeatureDAL.AddPropertyFeature(objclsPropertyFeature); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdatePropertyFeature(clsPropertyFeature objclsPropertyFeature, int pkPropertyFeatureID) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyFeatureDAL objclsPropertyFeatureDAL = new clsPropertyFeatureDAL(); // Creating object of Dataccess  
                return objclsPropertyFeatureDAL.UpdatePropertyFeature(objclsPropertyFeature, pkPropertyFeatureID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetPropertyFeature(int pkPropertyFeatureID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyFeatureDAL objclsPropertyFeatureDAL = new clsPropertyFeatureDAL(); // Creating object of Dataccess  
                return objclsPropertyFeatureDAL.GetPropertyFeature(pkPropertyFeatureID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}