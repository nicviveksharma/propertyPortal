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
    public class clsLoginDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddLogin(clsLogin objclsLogin) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_Login_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@loginUsername", objclsLogin.loginUsername);
                    cmd.Parameters.AddWithValue("@loginPassword", objclsLogin.loginPassword);
                    cmd.Parameters.AddWithValue("@loginSalt", objclsLogin.loginSalt);
                    cmd.Parameters.AddWithValue("@loginRole", objclsLogin.loginRole);
                    cmd.Parameters.AddWithValue("@isActive", objclsLogin.isActive);
                    cmd.Parameters.AddWithValue("@isVerified", objclsLogin.isVerified);
                    cmd.Parameters.AddWithValue("@createdOn", objclsLogin.createdOn);
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();

                    int Result = 0; ;
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
        public int UpdateLogin(clsLogin objclsLogin, int pkLoginID)
        {
            try
            {
                using (cmd = new SqlCommand("sp_Login_Update", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkLoginID", pkLoginID);
                    cmd.Parameters.AddWithValue("@loginPassword", objclsLogin.loginPassword);
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
        public int EnableDisableLogin(int pkLoginID, bool isActive)
        {
            try
            {
                using (cmd = new SqlCommand("sp_Login_EnableDisable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@pkLoginID", pkLoginID);
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
        public DataTable GetLogin(string loginUsername, int loginRole)
        {
            using (cmd = new SqlCommand("sp_Login_Get", con))
            {
                try
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@loginUsername", loginUsername);
                    cmd.Parameters.AddWithValue("@loginRole", loginRole);
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