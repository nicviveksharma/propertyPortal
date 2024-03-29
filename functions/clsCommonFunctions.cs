﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Web;
using System.Xml.XPath;

namespace PropertyPortal.functions
{
    public class clsCommonFunctions
    {        
        public static string getConfig(string configSetting)
        {
            try
            {                
                XPathDocument doc = new XPathDocument(ConfigurationManager.AppSettings["siteurl"].ToString() + "config/config.xml");
                XPathNavigator nav = doc.CreateNavigator();             
                XPathExpression expr;
                expr = nav.Compile(@"/settings/" + configSetting);
                XPathNodeIterator iterator = nav.Select(expr);                
                while (iterator.MoveNext())
                {
                    return iterator.Current.Value;
                }
                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GetIpValue()
        {
            string ip = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (string.IsNullOrEmpty(ip))
            {
                ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            if (ip.Equals("::1"))
            {
                ip = "127.0.0.1";
            }
            return ip;
        }       
    }
}