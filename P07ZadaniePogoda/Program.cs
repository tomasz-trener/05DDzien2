using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P07ZadaniePogoda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wyniki = new List<string>();
            do
            {
                Console.WriteLine("Proszę podaj nazwę miasta");
                string nazwaMiasta = Console.ReadLine();

                if (nazwaMiasta == "")
                    break;

                string url = string.Format("https://www.google.com/search?q=pogoda+{0}", nazwaMiasta);

                string dane = new WebClient().DownloadString(url);

                char szukanyZnak = '°';
                int poz = dane.IndexOf(szukanyZnak);

                int pozStop = poz - 1;
                while (dane[pozStop] != '>')
                    pozStop--;

                string wynik = dane.Substring(pozStop + 1, poz - pozStop + 1);
                wyniki.Add(string.Format("w miescie {0} jest {1} temperatura", nazwaMiasta, wynik));
                Console.WriteLine(wynik);
            } while (true);

            string linie = string.Join("\n", wyniki);
            File.WriteAllText(@"c:\dane\pogodaHistoria.txt", linie);

           

        }
    }
}
