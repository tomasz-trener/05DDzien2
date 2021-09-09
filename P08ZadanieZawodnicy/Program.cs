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


            // rozdzielenie danych wejściowych na tablice weirszy 
            string[] wiersze= 
                dane.Split(new char[] { '\n','\r' },
                    StringSplitOptions.RemoveEmptyEntries);

            // wczytujemy szukany kraj
            Console.WriteLine("Podaj kraj");
            string kraj = Console.ReadLine().ToLower();

            // najpierw przygotowujmy liste w której bedziemy przechowywać 
            // przefiltrowane kraje 
            List<string> przefiltrowaneWiersze = new List<string>();


            //iterujemy po kazdym wierszu (bez nagłówka dlatego od 1 ) 
            for (int i = 1; i < wiersze.Length; i++)
            {
                Console.WriteLine(wiersze[i]); // wypisujemy dane wiersza 
                string[] komorki = wiersze[i].Split(';'); // rozdzialmy i-ty wiersz na komórki , zeby dostać iię do poszczególnych kolumn 
                if (komorki[4].ToLower() == kraj) // sprawdzamy czy w kolumnie 4-tej znajduje się ten szukany kraj
                    przefiltrowaneWiersze.Add(wiersze[i]); // jezeli tak to dodajmy ten wiersz do naszej listy 
            }

            //zapisujemy całośc w pliku 
            File.WriteAllLines(@"c:\dane\zawodnicy.txt", przefiltrowaneWiersze);
            Console.ReadKey();
        }
    }
}
