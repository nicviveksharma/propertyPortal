using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsRentTypeBAL
    {
        public int AddRentTypeMaster(clsRentType objclsRentType) // passing Bussiness object Here  
        {
            try
            {
                clsRentTypeDAL objclsRentTypeDAL = new clsRentTypeDAL(); // Creating object of Dataccess  
                return objclsRentTypeDAL.AddRentTypeMaster(objclsRentType); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateRentTypeMaster(clsRentType objclsRentType, int pkRentTypeID) // passing Bussiness object Here  
        {
            try
            {
                clsRentTypeDAL objclsRentTypeDAL = new clsRentTypeDAL(); // Creating object of Dataccess  
                return objclsRentTypeDAL.UpdateRentTypeMaster(objclsRentType, pkRentTypeID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetRentTypeMaster(int pkRentTypeID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsRentTypeDAL objclsRentTypeDAL = new clsRentTypeDAL(); // Creating object of Dataccess  
                return objclsRentTypeDAL.GetRentTypeMaster(pkRentTypeID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisableRentTypeMaster(int pkRentTypeID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsRentTypeDAL objclsRentTypeDAL = new clsRentTypeDAL(); // Creating object of Dataccess  
                return objclsRentTypeDAL.EnableDisableRentTypeMaster(pkRentTypeID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}