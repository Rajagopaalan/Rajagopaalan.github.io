using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using System.Xml;
using System.Collections;
using System.Text.RegularExpressions;

namespace HotelManaegementSystemServices
{
    /// <summary>
    /// Summary description for BookingService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BookingService : System.Web.Services.WebService
    {

        [WebMethod]
        public String bookroom(string Name, string Ac, string Deluxe, string bed, string days, string creditcard,string CVV)
        {
            int check = 0;
            Boolean Actype = false;
            Boolean Deluxetype = false;
            Boolean bedtype = false;
            int bookingid = -1 ;
            int i = 0;
            String booking_details=null;
            String[] text = new String[10000];
     

            string fileName = "bookingdetails.txt";
            string value = "";
            string status = "";
            string bookedroomno = "";
            string inputval = Ac + " " + Deluxe + " " + bed;

            bool cvvl = new Regex("^[0-9]*$").IsMatch(CVV);
              bool credicardval = new Regex("^[0-9]*$").IsMatch(creditcard);
              if (CVV.Length < 3 || cvvl == false) { status = "INvalid card details"; return status; }
              if (creditcard.Length < 14 || creditcard.Length > 18 || credicardval == false) { status = "INvalid card details"; return status; }



            string fLocationread = Path.Combine(HttpRuntime.AppDomainAppPath, "Hoteldetails.txt"); // From server root to current            
            if (!File.Exists(fLocationread))
            {
                return "File not exist";
            }
            string r = "";
            string s = "";
            using (StreamReader sr = File.OpenText(fLocationread))
            {
                s = sr.ReadLine();
                while ((s = sr.ReadLine()) != null)
                {
                   // status = s;
                    //break
                    if (s == null) { break; }
                 
                  
                  String[] readtokenlines =s.Split();
                  if (readtokenlines.Length <6 ) { break; }
            
                    if (readtokenlines[1] == Ac && readtokenlines[5] == "yes") { Actype = true; } if (readtokenlines[2] == bed && readtokenlines[5] == "yes") { bedtype = true; } if (readtokenlines[3] == Deluxe && readtokenlines[5] == "yes") { Deluxetype = true; }
                //     if (readtokenlines[1] == Ac ) { Actype = true; } if (readtokenlines[1] == Ac ) { bedtype = true; } if (readtokenlines[1] == Deluxe ) { Deluxetype = true; }
                    
                    if (Actype && bedtype && Deluxetype)
                    {
                        value = readtokenlines[0] + readtokenlines[1] + " " + readtokenlines[2] + " " + readtokenlines[3];
                        status = "Room booked.Please note this booking id. "+Convert.ToString(bookingid);
                        bookedroomno = readtokenlines[0];
                        Random rand = new Random();
                        bookingid = rand.Next(1000, 5000);
                        status = "Room booked.Please note this booking id. " + Convert.ToString(bookingid);
                        break;
                    }
                    else if (Actype == false && Deluxetype == false && bedtype == false) { status = "Not booked." + readtokenlines[1] + "and" + readtokenlines[3] + "and" + readtokenlines[2] + "not available.Please choose other combination"; }

                    else if (bedtype == false && Actype == false) { status = "Not booked." + readtokenlines[1] + "and" + readtokenlines[2] + "not available.Please choose other combination"; }
                    else if (bedtype == false && Deluxetype == false) { status = "Not booked." + readtokenlines[3] + "and" + readtokenlines[2] + "not available.Please choose other combination"; }
                    else if (Actype == false && Deluxetype == false) { status = "Not booked." + readtokenlines[1] + "and" + readtokenlines[3] + "not available.Please choose other combination."; }
                   
                    else if (Actype == false) { status = "Not booked." + readtokenlines[1] + "not available.Please choose other combination"; }
                    else if (Deluxetype == false) { status = "Not booked." + readtokenlines[3] + "not available.Please choose other combination"; }
                    else if (bedtype == false) { status = "Not booked." + readtokenlines[2] + "not available.Please choose other combination"; }
                    else { status = "All rooms are full.Room not availbale"; return status; }
                    // if(readtokenlines[2]==Ac && readtokenlines )
                    //   r = r + "-" + s;
                }
            }

            

            string fLocationupdate = Path.Combine(HttpRuntime.AppDomainAppPath, "Hoteldetails.txt"); // From server root to current            
            if (!File.Exists(fLocationupdate))
            {
                return "File not exist";
            }
            string ru = "";
            string su = "";
         //   ArrayList text = new ArrayList();
         
         
            using (StreamReader sr = File.OpenText(fLocationread))
            {
                while ((s = sr.ReadLine()) != null)
                {
                if (i == text.Length) { break; }
                    String[] ssplit = s.Split(' ');
                    if (ssplit.Length < 6) { break; }

                    if (bookedroomno == ssplit[0]) { text[i] = ssplit[0] + " " + ssplit[1] + " " + ssplit[2] + " " + ssplit[3] + " " + ssplit[4] + " " + "No";
                    booking_details = Convert.ToString(Convert.ToInt32(bookingid))+" "+ssplit[0] + " " + ssplit[1] + " " + ssplit[2] + " " + ssplit[3] + " " + ssplit[4] + " " + Name + " "+days ;
                    }
                    else
                    {
                        text[i]=s;
                    }
                    i++;
                }
                
            }



            string fLocationwrite = Path.Combine(HttpRuntime.AppDomainAppPath, "Hoteldetails.txt");
            string fLocationrewrite = Path.Combine(HttpRuntime.AppDomainAppPath, "Hoteldetails.txt");
            if (check == 0) { 
           
            if (File.Exists(fLocationwrite))
            {
                File.Delete(fLocationwrite);
            }
            check=1;
        }
            int counttemp = 0;
            for (int x = 0; x < text.Length; x++)
            {
                counttemp++;
                if (counttemp == 20) { break; }
                using (StreamWriter sw = File.AppendText(fLocationrewrite))
                {
                    if (text[x] != "")
                    {
                        sw.WriteLine(text[x]);
                    }

                }

            }
            if (!booking_details.Equals(null))
            {
                string fLocationbookingdetails = Path.Combine(HttpRuntime.AppDomainAppPath, "Bookingdetails.txt");
                using (StreamWriter swr = File.AppendText(fLocationbookingdetails))
                {

                    swr.WriteLine(booking_details);

                }
            }

            return status;
        }
    }
}
