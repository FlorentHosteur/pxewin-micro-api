using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

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

        [WebMethod]
        public string GetComputerName(String Mac)
        {
            string sGetComputerName;

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int length = 10;
            var random       = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length)
                                                    .Select(s => s[random.Next(s.Length)]).ToArray());


            sGetComputerName = "WIN2KX-" + randomString;

            return sGetComputerName;

        }
    }

    
}
