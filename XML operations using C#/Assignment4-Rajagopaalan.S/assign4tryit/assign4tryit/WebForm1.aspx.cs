using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assign4tryit
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string xml = TextBox1.Text;
            string xsd = TextBox2.Text;
         //   ServiceReference1.XmlDataprocessSoapClient svc = new ServiceReference1.XmlDataprocessSoapClient();
            ServiceReference1.xmlserviceSoapClient svc = new ServiceReference1.xmlserviceSoapClient();
           Label1.Text = svc.verification(xml,xsd);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
           
            
            
            
        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            string xml = TextBox3.Text;
            string xpa = TextBox4.Text;
            ServiceReference1.xmlserviceSoapClient svd = new ServiceReference1.xmlserviceSoapClient();
           TextBox5.Text =  svd.xPathfind(xml, xpa);
        }

       
    }
}