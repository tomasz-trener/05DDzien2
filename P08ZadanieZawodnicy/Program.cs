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

            Console.WriteLine("Podaj kraj");
            string kraj = Console.ReadLine().ToLower();

            List<string> przefiltrowaneWiersze = new List<string>();
            for (int i = 1; i < wiersze.Length; i++)
            {
                Console.WriteLine(wiersze[i]);
                string[] komorki = wiersze[i].Split(';');
                if (komorki[4].ToLower() == kraj)
                    przefiltrowaneWiersze.Add(wiersze[i]);
            }

            File.WriteAllLines(@"c:\dane\zawodnicy.txt", przefiltrowaneWiersze);

            Console.ReadKey();
        }
    }
}
