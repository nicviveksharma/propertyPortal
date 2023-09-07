using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsFeatureBAL
    {
        public int AddFeatureMaster(clsFeature objclsFeature) // passing Bussiness object Here  
        {
            try
            {
                clsFeatureDAL objclsFeatureDAL = new clsFeatureDAL(); // Creating object of Dataccess  
                return objclsFeatureDAL.AddFeatureMaster(objclsFeature); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateFeatureMaster(clsFeature objclsFeature, int pkFeatureID) // passing Bussiness object Here  
        {
            try
            {
                clsFeatureDAL objclsFeatureDAL = new clsFeatureDAL(); // Creating object of Dataccess  
                return objclsFeatureDAL.UpdateFeatureMaster(objclsFeature, pkFeatureID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetFeatureMaster(int pkFeatureID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsFeatureDAL objclsFeatureDAL = new clsFeatureDAL(); // Creating object of Dataccess  
                return objclsFeatureDAL.GetFeatureMaster(pkFeatureID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisableFeatureMaster(int pkFeatureID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsFeatureDAL objclsFeatureDAL = new clsFeatureDAL(); // Creating object of Dataccess  
                return objclsFeatureDAL.EnableDisableFeatureMaster(pkFeatureID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}