using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Console_Dersleri_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);
            string dolarAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
                  
            string dolarSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;

            string euroAlis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            
            string euroSatis = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            Console.WriteLine("Dolar Alış Fiyatı: " + dolarAlis);
            Console.WriteLine("Dolar Satış Fiyatı: " + dolarSatis);
            Console.WriteLine("Euro Alış Fiyatı: " + euroAlis);
            Console.WriteLine("Euro Satış Fiyatı: " + euroSatis);

            Console.ReadLine();
        }
    }
}
