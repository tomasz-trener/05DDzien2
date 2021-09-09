using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P06WebClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.google.com/search?q=pogoda+warszawa";

            string dane = new WebClient().DownloadString(url);

            File.WriteAllText(@"c:\dane\pogoda.html", dane);

        }
    }
}
