using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P08ZadanieZawodnicy
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";

            string dane = new WebClient().DownloadString(url);

            string[] wiersze= 
                dane.Split(new char[] { '\n','\r' },
                    StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i < wiersze.Length; i++)
                Console.WriteLine(wiersze[i]);


            Console.ReadKey();
        }
    }
}
