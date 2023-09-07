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
    public class clsPropertyFacilityDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddPropertyFacility(clsPropertyFacility objclsPropertyFacility) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyFacility_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkPropertyID", objclsPropertyFacility.fkPropertyID);
                    cmd.Parameters.AddWithValue("@fkFacilityID", objclsPropertyFacility.fkFacilityID);
                    cmd.Parameters.AddWithValue("@propertyFacilityDistance", objclsPropertyFacility.propertyFacilityDistance);
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
        public int UpdatePropertyFacility(clsPropertyFacility objclsPropertyCategory, int pkPropertyCategoryID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyCategory_Master_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    /*cmd.Parameters.AddWithValue("@pkPropertyCategoryID", pkPropertyCategoryID);
                    cmd.Parameters.AddWithValue("@propertyCategoryName", objclsPropertyCategory.propertyCategoryName);
                    cmd.Parameters.AddWithValue("@isActive", objclsPropertyCategory.isActive);*/
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
        public DataTable GetPropertyFacility(int pkPropertyCategoryID, int isActive)
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