using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Services;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.IO;
namespace Xmlvalidation
{
    /// <summary>
    /// Summary description for xmlservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class xmlservice : System.Web.Services.WebService
    {

        private static Boolean aerr = false;
        private static string errmessage;

        [WebMethod]
        public string xPathfind(string xmlpath, string xPathexpr)
        {

        
            string nodeVal = "";
          
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlpath);

            XmlNodeList no = doc.DocumentElement.SelectNodes(xPathexpr);

            foreach (XmlNode node in no)
            {
                string nodetext = node.InnerText;
                string nodv = ":" + nodetext + "\r\n";
                nodeVal += nodv;
            }

            return nodeVal;
        }


        [WebMethod]
        public string verification(string xmlpath, string xsdpath)
        {

            XmlReaderSettings readerconfig = new XmlReaderSettings();
            readerconfig.ValidationType = ValidationType.Schema;
            XmlSchemaSet sch = new XmlSchemaSet();
            sch.Add(null, xsdpath);
            errmessage = "";
            readerconfig.Schemas = sch;
            readerconfig.ValidationEventHandler += new ValidationEventHandler(validate);
            aerr = false;
            XmlReader read = XmlReader.Create(xmlpath, readerconfig);

            while (read.Read()) ;
            if (aerr == false)
            {
                string m = "No error";
                return m;
            }
            return errmessage;
        }
        private static void validate(object sender, ValidationEventArgs e)
        {
            aerr = true;
            string s = "Validation Error: " + e.Message + "\n";
            errmessage += s;
        }
    }
}
