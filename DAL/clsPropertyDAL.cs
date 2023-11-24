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
    public class clsPropertyDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddProperty(clsProperty objclsProperty) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_Property_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkStateID", objclsProperty.fkStateID);
                    cmd.Parameters.AddWithValue("@fkDistrictID", objclsProperty.fkDistrictID);
                    cmd.Parameters.AddWithValue("@fkCityID", objclsProperty.fkCityID);
                    cmd.Parameters.AddWithValue("@fkPropertyCategoryID", objclsProperty.fkPropertyCategoryID);
                    cmd.Parameters.AddWithValue("@fkPropertyTypeID", objclsProperty.fkPropertyTypeID);
                    cmd.Parameters.AddWithValue("@fkRentTypeID", objclsProperty.fkRentTypeID);
                    cmd.Parameters.AddWithValue("@fkOwnerUserID", objclsProperty.fkOwnerUserID);
                    cmd.Parameters.AddWithValue("@propertyTitle", objclsProperty.propertyTitle);
                    cmd.Parameters.AddWithValue("@propertyShortTitle", objclsProperty.propertyShortTitle);
                    cmd.Parameters.AddWithValue("@propertyLink", objclsProperty.propertyLink);
                    cmd.Parameters.AddWithValue("@propertyShortDescription", objclsProperty.propertyShortDescription);
                    cmd.Parameters.AddWithValue("@propertyLongDescription", objclsProperty.propertyLongDescription);
                    cmd.Parameters.AddWithValue("@propertyLatitude", objclsProperty.propertyLatitude);
                    cmd.Parameters.AddWithValue("@propertyLongitude", objclsProperty.propertyLongitude);
                    cmd.Parameters.AddWithValue("@propertyAddress", objclsProperty.propertyAddress);
                    cmd.Parameters.AddWithValue("@propertyTotalFloor", objclsProperty.propertyTotalFloor);
                    cmd.Parameters.AddWithValue("@propertyTotalBedroom", objclsProperty.propertyTotalBedroom);
                    cmd.Parameters.AddWithValue("@propertyTotalBathroom", objclsProperty.propertyTotalBathroom);
                    cmd.Parameters.AddWithValue("@propertyArea", objclsProperty.propertyArea);
                    cmd.Parameters.AddWithValue("@propertyPrice", objclsProperty.propertyPrice);
                    cmd.Parameters.AddWithValue("@propertyYoutubeLink", objclsProperty.propertyYoutubeLink);
                    cmd.Parameters.AddWithValue("@propertySEOTitle", objclsProperty.propertySEOTitle);
                    cmd.Parameters.AddWithValue("@propertySEODescription", objclsProperty.propertySEODescription);
                    cmd.Parameters.AddWithValue("@isFeatured", objclsProperty.isFeatured);
                    cmd.Parameters.AddWithValue("@isActive", objclsProperty.isActive);
                    cmd.Parameters.AddWithValue("@isVerified", objclsProperty.isVerified);
                    cmd.Parameters.AddWithValue("@createdBy", objclsProperty.createdBy);
                    cmd.Parameters.AddWithValue("@createdOn", objclsProperty.createdOn);
                    cmd.Parameters.AddWithValue("@modifiedBy", objclsProperty.modifiedBy);
                    cmd.Parameters.AddWithValue("@modifiedOn", objclsProperty.modifiedOn);
                    cmd.Parameters.AddWithValue("@verifiedBy", objclsProperty.verifiedBy);
                    cmd.Parameters.AddWithValue("@verifiedOn", objclsProperty.verifiedOn);

                    if (con.State.Equals(ConnectionState.Closed))
                    con.Open();
                    int Result = 0;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Result = Convert.ToInt32(reader[0]);
                        }
                    }
                    reader.Close();
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
        public int UpdateProperty(clsProperty objclsProperty, int pkPropertyID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_Property_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyID", pkPropertyID);
                    cmd.Parameters.AddWithValue("@fkStateID", objclsProperty.fkStateID);
                    cmd.Parameters.AddWithValue("@fkDistrictID", objclsProperty.fkDistrictID);
                    cmd.Parameters.AddWithValue("@fkCityID", objclsProperty.fkCityID);
                    cmd.Parameters.AddWithValue("@fkPropertyCategoryID", objclsProperty.fkPropertyCategoryID);
                    cmd.Parameters.AddWithValue("@fkPropertyTypeID", objclsProperty.fkPropertyTypeID);
                    cmd.Parameters.AddWithValue("@fkRentTypeID", objclsProperty.fkRentTypeID);
                    cmd.Parameters.AddWithValue("@propertyTitle", objclsProperty.propertyTitle);
                    cmd.Parameters.AddWithValue("@propertyShortTitle", objclsProperty.propertyShortTitle);
                    cmd.Parameters.AddWithValue("@propertyLink", objclsProperty.propertyLink);
                    cmd.Parameters.AddWithValue("@propertyShortDescription", objclsProperty.propertyShortDescription);
                    cmd.Parameters.AddWithValue("@propertyLongDescription", objclsProperty.propertyLongDescription);
                    cmd.Parameters.AddWithValue("@propertyLatitude", objclsProperty.propertyLatitude);
                    cmd.Parameters.AddWithValue("@propertyLongitude", objclsProperty.propertyLongitude);
                    cmd.Parameters.AddWithValue("@propertyAddress", objclsProperty.propertyAddress);
                    cmd.Parameters.AddWithValue("@propertyTotalFloor", objclsProperty.propertyTotalFloor);
                    cmd.Parameters.AddWithValue("@propertyTotalBedroom", objclsProperty.propertyTotalBedroom);
                    cmd.Parameters.AddWithValue("@propertyTotalBathroom", objclsProperty.propertyTotalBathroom);
                    cmd.Parameters.AddWithValue("@propertyArea", objclsProperty.propertyArea);
                    cmd.Parameters.AddWithValue("@propertyPrice", objclsProperty.propertyPrice);
                    cmd.Parameters.AddWithValue("@propertyYoutubeLink", objclsProperty.propertyYoutubeLink);
                    cmd.Parameters.AddWithValue("@propertySEOTitle", objclsProperty.propertySEOTitle);
                    cmd.Parameters.AddWithValue("@propertySEODescription", objclsProperty.propertySEODescription);
                    cmd.Parameters.AddWithValue("@isFeatured", objclsProperty.isFeatured);
                    cmd.Parameters.AddWithValue("@isActive", objclsProperty.isActive);
                    cmd.Parameters.AddWithValue("@modifiedBy", objclsProperty.modifiedBy);
                    cmd.Parameters.AddWithValue("@modifiedOn", objclsProperty.modifiedOn);
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
        public int EnableDisableProperty(int pkPropertyID, bool isActive)
        {
            try
            {
                using (cmd = new SqlCommand("sp_Property_EnableDisable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyID", pkPropertyID);
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
        public DataTable GetProperty(int pkPropertyID, int isActive)
        {
            using (cmd = new SqlCommand("sp_Property_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyID", pkPropertyID);
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

        public DataTable GetPropertyMaster(int pkPropertyID, int isActive)
        {
            using (cmd = new SqlCommand("sp_Property_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkPropertyID", pkPropertyID);
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