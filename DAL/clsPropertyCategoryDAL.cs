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
    public class clsPropertyCategoryDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddPropertyCategoryMaster(clsPropertyCategory objclsPropertyCategory) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyCategory_Master_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@propertyCategoryName", objclsPropertyCategory.propertyCategoryName);
                    cmd.Parameters.AddWithValue("@isActive", objclsPropertyCategory.isActive);
                    cmd.Parameters.AddWithValue("@createdBy", objclsPropertyCategory.createdBy);
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    int Result = -2;
                    SqlDataReader dr = cmd.ExecuteReader();
                    cmd.Dispose();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Result = Convert.ToInt32(dr[0]);
                        }
                    }
                    con.Close();
                    return Result;
                }
            }
            catch
            {
                throw;
            }
        }
        public int UpdatePropertyCategoryMaster(clsPropertyCategory objclsPropertyCategory, int pkPropertyCategoryID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyCategory_Master_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyCategoryID", pkPropertyCategoryID);
                    cmd.Parameters.AddWithValue("@propertyCategoryName", objclsPropertyCategory.propertyCategoryName);
                    cmd.Parameters.AddWithValue("@isActive", objclsPropertyCategory.isActive);
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    int Result = -2;
                    SqlDataReader dr = cmd.ExecuteReader();
                    cmd.Dispose();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            Result = Convert.ToInt32(dr[0]);
                        }
                    }
                    con.Close();
                    return Result;
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
        public int EnableDisablePropertyCategoryMaster(int pkPropertyCategoryID, bool isActive)
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyCategory_Master_EnableDisable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyCategoryID", pkPropertyCategoryID);
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
        public DataTable GetPropertyCategoryMaster(int pkPropertyCategoryID, int isActive)
        {
            using (cmd = new SqlCommand("sp_PropertyCategory_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyCategoryID", pkPropertyCategoryID);
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