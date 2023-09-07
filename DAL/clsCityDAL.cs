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
    public class clsCityDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddCityMaster(clsCity objclsCity) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_City_Master_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fkDistrictID", objclsCity.fkDistrictID);
                    cmd.Parameters.AddWithValue("@cityName", objclsCity.cityName);
                    cmd.Parameters.AddWithValue("@isActive", objclsCity.isActive);
                    cmd.Parameters.AddWithValue("@createdBy", objclsCity.createdBy);
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
        public int UpdateCityMaster(clsCity objclsCity, int pkCityID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_City_Master_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkDistrictID", objclsCity.fkDistrictID);
                    cmd.Parameters.AddWithValue("@pkCityID", pkCityID);
                    cmd.Parameters.AddWithValue("@cityName", objclsCity.cityName);
                    cmd.Parameters.AddWithValue("@isActive", objclsCity.isActive);
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
        public int EnableDisableCityMaster(int pkCityID, bool isActive)
        {
            try
            {
                using (cmd = new SqlCommand("sp_City_Master_EnableDisable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkCityID", pkCityID);
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
        public DataTable GetCityMaster(int fkDistrictID, int pkCityID, int isActive)
        {
            using (cmd = new SqlCommand("sp_City_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkDistrictID", fkDistrictID);
                    cmd.Parameters.AddWithValue("@pkCityID", pkCityID);
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