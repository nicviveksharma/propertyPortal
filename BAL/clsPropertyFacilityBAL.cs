using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsPropertyFacilityBAL
    {
        public int AddPropertyFacility(clsPropertyFacility objclsPropertyFacility) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyFacilityDAL objclsPropertyFacilityDAL = new clsPropertyFacilityDAL(); // Creating object of Dataccess  
                return objclsPropertyFacilityDAL.AddPropertyFacility(objclsPropertyFacility); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdatePropertyFacility(clsPropertyFacility objclsPropertyFacility, int pkPropertyFacilityID) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyFacilityDAL objclsPropertyFacilityDAL = new clsPropertyFacilityDAL(); // Creating object of Dataccess  
                return objclsPropertyFacilityDAL.UpdatePropertyFacility(objclsPropertyFacility, pkPropertyFacilityID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetPropertyFacility(int pkPropertyFacilityID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyFacilityDAL objclsPropertyFacilityDAL = new clsPropertyFacilityDAL(); // Creating object of Dataccess  
                return objclsPropertyFacilityDAL.GetPropertyFacility(pkPropertyFacilityID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}