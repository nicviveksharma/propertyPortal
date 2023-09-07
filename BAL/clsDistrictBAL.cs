using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsDistrictBAL
    {
        public int AddDistrictMaster(clsDistrict objclsDistrict) // passing Bussiness object Here  
        {
            try
            {
                clsDistrictDAL objclsDistrictDAL = new clsDistrictDAL(); // Creating object of Dataccess  
                return objclsDistrictDAL.AddDistrictMaster(objclsDistrict); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateDistrictMaster(clsDistrict objclsDistrict, int pkDistrictID) // passing Bussiness object Here  
        {
            try
            {
                clsDistrictDAL objclsDistrictDAL = new clsDistrictDAL(); // Creating object of Dataccess  
                return objclsDistrictDAL.UpdateDistrictMaster(objclsDistrict, pkDistrictID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetDistrictMaster(int fkStateID, int pkDistrictID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsDistrictDAL objclsDistrictDAL = new clsDistrictDAL(); // Creating object of Dataccess  
                return objclsDistrictDAL.GetDistrictMaster(fkStateID, pkDistrictID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisableDistrictMaster(int pkDistrictID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsDistrictDAL objclsDistrictDAL = new clsDistrictDAL(); // Creating object of Dataccess  
                return objclsDistrictDAL.EnableDisableDistrictMaster(pkDistrictID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}