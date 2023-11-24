using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PropertyPortal.BO;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace PropertyPortal.DAL
{
    public class clsContactFormDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conPropertyPortalDB"].ToString());
        SqlCommand cmd;
        DataTable dt;
        public int AddContactFormDAL(clsContactForm objclsContactForm) // passing Bussiness object Here  
        {
            try
            {
                using (cmd = new SqlCommand("sp_ContactForm_Add", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", objclsContactForm.name);
                    cmd.Parameters.AddWithValue("@email", objclsContactForm.email);
                    cmd.Parameters.AddWithValue("@phone" , objclsContactForm.phone);  
                    cmd.Parameters.AddWithValue("@address",objclsContactForm.address);
                    cmd.Parameters.AddWithValue("@message", objclsContactForm.message);
                    cmd.Parameters.AddWithValue("@ip", objclsContactForm.ip);
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
    }
}