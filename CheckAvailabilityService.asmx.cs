using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using System.Xml;

namespace HotelManaegementSystemServices
{
    /// <summary>
    /// Summary description for CheckAvailabilityService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CheckAvailabilityService : System.Web.Services.WebService
    {

        [WebMethod]

        public string GetStringFromFile()
        {
            string fileName = "Hoteldetails.txt";
            string fLocation = Path.Combine(HttpRuntime.AppDomainAppPath, fileName); // From server root to current
            //   fLocation = Path.Combine(fLocation, fileName); // From current to App_Data
            if (!File.Exists(fLocation))
            {
                return "File not exist";
            }
            string r = "";
            string s = "";
            using (StreamReader sr = File.OpenText(fLocation))
            {
                //  string s = sr.ReadLine();
                // return s;


                while ((s = sr.ReadLine()) != null)
                {


                    r = r + s +"-";


                }
                return r;
            }
        }
    }
}
