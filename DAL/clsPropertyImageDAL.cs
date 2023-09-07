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
    public class clsPropertyImageDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddPropertyImage(clsPropertyImage objclsPropertyImage) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyImage_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkPropertyID", objclsPropertyImage.fkPropertyID);
                    cmd.Parameters.AddWithValue("@propertyImage", objclsPropertyImage.propertyImage);
                    cmd.Parameters.AddWithValue("@isFeaturedImage", objclsPropertyImage.isFeaturedImage);
                    cmd.Parameters.AddWithValue("@isBannerImage", objclsPropertyImage.isBannerImage);
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
        public int UpdatePropertyImage(clsPropertyImage objclsPropertyImage, int pkPropertyImageID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_PropertyImage_Master_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    /*cmd.Parameters.AddWithValue("@pkPropertyImageID", pkPropertyImageID);
                    cmd.Parameters.AddWithValue("@propertyCategoryName", objclsPropertyImage.propertyCategoryName);
                    cmd.Parameters.AddWithValue("@isActive", objclsPropertyImage.isActive);*/
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
        public DataTable GetPropertyImage(int pkPropertyImageID, int isActive)
        {
            using (cmd = new SqlCommand("sp_PropertyImage_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyImageID", pkPropertyImageID);
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