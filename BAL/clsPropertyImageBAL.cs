using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsPropertyImageBAL
    {
        public int AddPropertyImage(clsPropertyImage objclsPropertyImage) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyImageDAL objclsPropertyImageDAL = new clsPropertyImageDAL(); // Creating object of Dataccess  
                return objclsPropertyImageDAL.AddPropertyImage(objclsPropertyImage); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdatePropertyImage(clsPropertyImage objclsPropertyImage, int pkPropertyImageID) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyImageDAL objclsPropertyImageDAL = new clsPropertyImageDAL(); // Creating object of Dataccess  
                return objclsPropertyImageDAL.UpdatePropertyImage(objclsPropertyImage, pkPropertyImageID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetPropertyImage(int pkPropertyImageID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsPropertyImageDAL objclsPropertyImageDAL = new clsPropertyImageDAL(); // Creating object of Dataccess  
                return objclsPropertyImageDAL.GetPropertyImage(pkPropertyImageID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}