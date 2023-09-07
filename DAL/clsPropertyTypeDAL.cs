using PropertyPortal.BO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace PropertyPortal.DAL
{
    public class clsPropertyTypeDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddPropertyTypeMaster(clsPropertyType objclsPropertyType) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyType_Master_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@propertyTypeName", objclsPropertyType.propertyTypeName);
                    cmd.Parameters.AddWithValue("@isActive", objclsPropertyType.isActive);
                    cmd.Parameters.AddWithValue("@createdBy", objclsPropertyType.createdBy);
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    int Result = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    return Result;
                }
            }
            catch
            {
                throw;
            }
        }
        public int UpdatePropertyTypeMaster(clsPropertyType objclsPropertyType, int pkPropertyTypeID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyType_Master_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyTypeID", pkPropertyTypeID);
                    cmd.Parameters.AddWithValue("@propertyTypeName", objclsPropertyType.propertyTypeName);
                    cmd.Parameters.AddWithValue("@isActive", objclsPropertyType.isActive);
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public int EnableDisablePropertyTypeMaster(int pkPropertyTypeID, bool isActive)
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyType_Master_EnableDisable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyTypeID", pkPropertyTypeID);
                    cmd.Parameters.AddWithValue("@isActive", isActive);
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    int result = cmd.ExecuteNonQuery();
                    con.Close();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
        public DataTable GetPropertyTypeMaster(int pkPropertyTypeID, int isActive)
        {
            using (cmd = new SqlCommand("sp_PropertyType_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyTypeID", pkPropertyTypeID);
                    cmd.Parameters.AddWithValue("@isActive", isActive);
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}