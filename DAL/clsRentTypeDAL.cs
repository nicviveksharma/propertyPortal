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
    public class clsRentTypeDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddRentTypeMaster(clsRentType objclsRentType) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_RentType_Master_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@rentTypeName", objclsRentType.rentTypeName);
                    cmd.Parameters.AddWithValue("@isActive", objclsRentType.isActive);
                    cmd.Parameters.AddWithValue("@createdBy", objclsRentType.createdBy);
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
                        dr.Close();
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
        public int UpdateRentTypeMaster(clsRentType objclsRentType, int pkRentTypeID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_RentType_Master_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkRentTypeID", pkRentTypeID);
                    cmd.Parameters.AddWithValue("@rentTypeName", objclsRentType.rentTypeName);
                    cmd.Parameters.AddWithValue("@isActive", objclsRentType.isActive);
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
                        dr.Close();
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
        public int EnableDisableRentTypeMaster(int pkRentTypeID, bool isActive)
        {
            try
            {
                using (cmd = new SqlCommand("sp_RentType_Master_EnableDisable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkRentTypeID", pkRentTypeID);
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
        public DataTable GetRentTypeMaster(int pkRentTypeID, int isActive)
        {
            using (cmd = new SqlCommand("sp_RentType_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkRentTypeID", pkRentTypeID);
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