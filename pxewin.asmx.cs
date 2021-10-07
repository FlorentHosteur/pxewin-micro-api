﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Serilog;


namespace PXEwin
{
    /// <summary>
    /// Summary description for mdtsample
    /// </summary>
    [WebService(Namespace = "http://hosteur.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class pxewin : System.Web.Services.WebService
    {
        private static Serilog.Core.Logger mylog = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File(@"C:\inetpub\logs\LogFiles\pxelog\PXEwin.log", rollingInterval: RollingInterval.Day).CreateLogger();

        [WebMethod]
        public string GetComputerName(String MacAddress)
        {
            // Debug
            mylog.Debug(string.Format("Calling GetComputerName, with param {0}", MacAddress));

            string sGetComputerName;

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 4;
            var random       = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());


            sGetComputerName = "WIN2KX-" + randomString;

            return sGetComputerName;

        }

        [WebMethod]
        public string GetComputerPassword(String MacAddress)
        {
            // Debug
            mylog.Debug(string.Format("Calling GetComputerPassword, with param {0}", MacAddress));

            string sGetComputerPassword;

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789%{[]}@&$%~";
            int length = 14;
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());


            sGetComputerPassword = randomString;

            return sGetComputerPassword;
            
        }

        [WebMethod]
        public string GetOSType(String MacAddress)
        {
            // Debug
            mylog.Debug(string.Format("Calling GetOSType, with param {0}", MacAddress));

            string sGetOSType;

            sGetOSType = "WSRV2K19STD";

            return sGetOSType;

        }


    }


}
