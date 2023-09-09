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
    public class clsPropertyFeatureDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddPropertyFeature(clsPropertyFeature objclsPropertyFeature) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyFeature_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkPropertyID", objclsPropertyFeature.fkPropertyID);
                    cmd.Parameters.AddWithValue("@fkFeatureID", objclsPropertyFeature.fkFeatureID);
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
        public int UpdatePropertyFeature(clsPropertyFeature objclsPropertyFeature, int pkPropertyFeatureID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyFeature_Master_Update", con))
                {
                    /*cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyFeatureID", pkPropertyFeatureID);
                    cmd.Parameters.AddWithValue("@propertyCategoryName", objclsPropertyFeature.propertyCategoryName);
                    cmd.Parameters.AddWithValue("@isActive", objclsPropertyFeature.isActive);*/
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
        public DataTable GetPropertyFeature(int pkPropertyFeatureID, int isActive)
        {
            using (cmd = new SqlCommand("sp_PropertyFeature_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyFeatureID", pkPropertyFeatureID);
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