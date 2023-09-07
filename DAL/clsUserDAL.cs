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
    public class clsUserDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddUser(clsUser objclsUser) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_User_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkLoginID", objclsUser.fkLoginID);
                    cmd.Parameters.AddWithValue("@userFirstName", objclsUser.userFirstName);
                    cmd.Parameters.AddWithValue("@userMiddleName", objclsUser.userMiddleName);
                    cmd.Parameters.AddWithValue("@userLastName", objclsUser.userLastName);
                    cmd.Parameters.AddWithValue("@userEmailAddress", objclsUser.userEmailAddress);
                    cmd.Parameters.AddWithValue("@userMobileNo", objclsUser.userMobileNo);
                    cmd.Parameters.AddWithValue("@userCompanyName", objclsUser.userCompanyName);
                    cmd.Parameters.AddWithValue("@userCompanyAddress", objclsUser.userCompanyAddress);
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
        public int UpdateUser(clsUser objclsUser, int pkStateID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_User_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    /*cmd.Parameters.AddWithValue("@pkStateID", pkStateID);
                    cmd.Parameters.AddWithValue("@stateName", objclsUser.stateName);
                    cmd.Parameters.AddWithValue("@isActive", objclsUser.isActive);*/
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
        public DataTable GetUser(int fkLoginID, int isActive, int isVerified)
        {
            using (cmd = new SqlCommand("sp_User_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkLoginID", fkLoginID);
                    cmd.Parameters.AddWithValue("@isActive", isActive);
                    cmd.Parameters.AddWithValue("@isVerified", isVerified);
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
        public DataTable GetUserMaster(int fkLoginID, int isActive, int isVerified)
        {
            using (cmd = new SqlCommand("sp_User_Master_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fkLoginID", fkLoginID);
                    cmd.Parameters.AddWithValue("@isActive", isActive);
                    cmd.Parameters.AddWithValue("@isVerified", isVerified);
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