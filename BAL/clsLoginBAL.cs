using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsLoginBAL
    {
        public int AddLogin(clsLogin objclsLogin) // passing Bussiness object Here  
        {
            try
            {
                clsLoginDAL objclsLoginDAL = new clsLoginDAL(); // Creating object of Dataccess  
                return objclsLoginDAL.AddLogin(objclsLogin); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateLogin(clsLogin objclsLogin, int pkLoginID) // passing Bussiness object Here  
        {
            try
            {
                clsLoginDAL objclsLoginDAL = new clsLoginDAL(); // Creating object of Dataccess  
                return objclsLoginDAL.UpdateLogin(objclsLogin, pkLoginID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetLogin(string loginUsername, int loginRole) // passing Bussiness object Here  
        {
            try
            {
                clsLoginDAL objclsLoginDAL = new clsLoginDAL(); // Creating object of Dataccess  
                return objclsLoginDAL.GetLogin(loginUsername, loginRole); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisableLogin(int pkLoginID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsLoginDAL objclsLoginDAL = new clsLoginDAL(); // Creating object of Dataccess  
                return objclsLoginDAL.EnableDisableLogin(pkLoginID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}