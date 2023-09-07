using PropertyPortal.BO;
using PropertyPortal.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.BAL
{
    public class clsStateBAL
    {
        public int AddStateMaster(clsState objclsState) // passing Bussiness object Here  
        {
            try
            {
                clsStateDAL objclsStateDAL = new clsStateDAL(); // Creating object of Dataccess  
                return objclsStateDAL.AddStateMaster(objclsState); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int UpdateStateMaster(clsState objclsState, int pkStateID) // passing Bussiness object Here  
        {
            try
            {
                clsStateDAL objclsStateDAL = new clsStateDAL(); // Creating object of Dataccess  
                return objclsStateDAL.UpdateStateMaster(objclsState, pkStateID); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public DataTable GetStateMaster(int pkStateID, int isActive) // passing Bussiness object Here  
        {
            try
            {
                clsStateDAL objclsStateDAL = new clsStateDAL(); // Creating object of Dataccess  
                return objclsStateDAL.GetStateMaster(pkStateID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }

        public int EnableDisableStateMaster(int pkStateID, bool isActive) // passing Bussiness object Here  
        {
            try
            {
                clsStateDAL objclsStateDAL = new clsStateDAL(); // Creating object of Dataccess  
                return objclsStateDAL.EnableDisableStateMaster(pkStateID, isActive); // calling Method of DataAccess  
            }
            catch
            {
                throw;
            }
        }
    }
}