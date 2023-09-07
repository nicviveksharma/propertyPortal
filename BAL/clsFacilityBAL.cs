using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsFacilityBAL
    {
        public int AddFacilityMaster(clsFacility objclsFacility) // passing Bussiness object Here  
        {
            try
            {
                clsFacilityDAL objclsFacilityDAL = new clsFacilityDAL(); // Creating object of Dataccess  
                return objclsFacilityDAL.AddFacilityMaster(objclsFacility); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateFacilityMaster(clsFacility objclsFacility, int pkFacilityID) // passing Bussiness object Here  
        {
            try
            {
                clsFacilityDAL objclsFacilityDAL = new clsFacilityDAL(); // Creating object of Dataccess  
                return objclsFacilityDAL.UpdateFacilityMaster(objclsFacility, pkFacilityID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetFacilityMaster(int pkFacilityID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsFacilityDAL objclsFacilityDAL = new clsFacilityDAL(); // Creating object of Dataccess  
                return objclsFacilityDAL.GetFacilityMaster(pkFacilityID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisableFacilityMaster(int pkFacilityID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsFacilityDAL objclsFacilityDAL = new clsFacilityDAL(); // Creating object of Dataccess  
                return objclsFacilityDAL.EnableDisableFacilityMaster(pkFacilityID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}