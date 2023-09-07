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
    public class clsFeatureDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddFeatureMaster(clsFeature objclsFeature) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_Feature_Master_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@featureName", objclsFeature.featureName);
                    cmd.Parameters.AddWithValue("@isActive", objclsFeature.isActive);
                    cmd.Parameters.AddWithValue("@createdBy", objclsFeature.createdBy);
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
        public int UpdateFeatureMaster(clsFeature objclsFeature, int pkFeatureID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_Feature_Master_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkFeatureID", pkFeatureID);
                    cmd.Parameters.AddWithValue("@featureName", objclsFeature.featureName);
                    cmd.Parameters.AddWithValue("@isActive", objclsFeature.isActive);
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
        public int EnableDisableFeatureMaster(int pkFeatureID, bool isActive)
        {
            try
            {
                using (cmd = new SqlCommand("sp_Feature_Master_EnableDisable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkFeatureID", pkFeatureID);
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
        public DataTable GetFeatureMaster(int pkFeatureID, int isActive)
        {
            using (cmd = new SqlCommand("sp_Feature_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkFeatureID", pkFeatureID);
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