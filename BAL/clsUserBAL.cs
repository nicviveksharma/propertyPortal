using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsUserBAL
    {
        public int AddUser(clsUser objclsUser) // passing Bussiness object Here  
        {
            try
            {
                clsUserDAL objclsUserDAL = new clsUserDAL(); // Creating object of Dataccess  
                return objclsUserDAL.AddUser(objclsUser); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateUser(clsUser objclsUser, int pkUserID) // passing Bussiness object Here  
        {
            try
            {
                clsUserDAL objclsUserDAL = new clsUserDAL(); // Creating object of Dataccess  
                return objclsUserDAL.UpdateUser(objclsUser, pkUserID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetUser(int fkLoginID, int isActive, int isVerified) // passing Bussiness object Here  
        {
            try
            {
                clsUserDAL objclsUserDAL = new clsUserDAL(); // Creating object of Dataccess  
                return objclsUserDAL.GetUser(fkLoginID, isActive, isVerified); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
        public DataTable GetUserMaster(int fkLoginID, int isActive, int isVerified) // passing Bussiness object Here  
        {
            try
            {
                clsUserDAL objclsUserDAL = new clsUserDAL(); // Creating object of Dataccess  
                return objclsUserDAL.GetUserMaster(fkLoginID, isActive, isVerified); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}