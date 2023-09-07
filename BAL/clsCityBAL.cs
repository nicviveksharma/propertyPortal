using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsCityBAL
    {
        public int AddCityMaster(clsCity objclsCity) // passing Bussiness object Here  
        {
            try
            {
                clsCityDAL objclsCityDAL = new clsCityDAL(); // Creating object of Dataccess  
                return objclsCityDAL.AddCityMaster(objclsCity); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateCityMaster(clsCity objclsCity, int pkCityID) // passing Bussiness object Here  
        {
            try
            {
                clsCityDAL objclsCityDAL = new clsCityDAL(); // Creating object of Dataccess  
                return objclsCityDAL.UpdateCityMaster(objclsCity, pkCityID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetCityMaster(int fkDistrictID, int pkCityID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsCityDAL objclsCityDAL = new clsCityDAL(); // Creating object of Dataccess  
                return objclsCityDAL.GetCityMaster(fkDistrictID, pkCityID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisableCityMaster(int pkCityID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsCityDAL objclsCityDAL = new clsCityDAL(); // Creating object of Dataccess  
                return objclsCityDAL.EnableDisableCityMaster(pkCityID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}