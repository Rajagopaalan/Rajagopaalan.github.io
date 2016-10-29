using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.IO;
using System.Xml;
using System.Web;
using System.Web.Services;

using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}



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


                r = r + s + "-";


            }
            return r;
        }

    }

}
