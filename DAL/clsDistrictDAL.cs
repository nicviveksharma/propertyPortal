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
    public class clsDistrictDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddDistrictMaster(clsDistrict objclsDistrict) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_District_Master_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fkStateID", objclsDistrict.fkStateID);
                    cmd.Parameters.AddWithValue("@districtName", objclsDistrict.districtName);
                    cmd.Parameters.AddWithValue("@isActive", objclsDistrict.isActive);
                    cmd.Parameters.AddWithValue("@createdBy", objclsDistrict.createdBy);
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
        public int UpdateDistrictMaster(clsDistrict objclsDistrict, int pkDistrictID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_District_Master_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fkStateID", objclsDistrict.fkStateID);
                    cmd.Parameters.AddWithValue("@pkDistrictID", pkDistrictID);
                    cmd.Parameters.AddWithValue("@districtName", objclsDistrict.districtName);
                    cmd.Parameters.AddWithValue("@isActive", objclsDistrict.isActive);
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
        public int EnableDisableDistrictMaster(int pkDistrictID, bool isActive)
        {
            try
            {
                using (cmd = new SqlCommand("sp_District_Master_EnableDisable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkDistrictID", pkDistrictID);
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
        public DataTable GetDistrictMaster(int fkStateID, int pkDistrictID, int isActive)
        {
            using (cmd = new SqlCommand("sp_District_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkStateID", fkStateID);
                    cmd.Parameters.AddWithValue("@pkDistrictID", pkDistrictID);
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