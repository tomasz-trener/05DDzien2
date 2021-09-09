using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace P12ZadanieKolekcjeWieloWymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane = new WebClient().DownloadString(url);

            // wczytanie danych do tablicy wierszy 
            string[] wiersze =
                dane.Split(new char[] { '\n', '\r' },
                    StringSplitOptions.RemoveEmptyEntries);


            // tab dwuwymiarowa 

            // tutaj wyliczamy liczbę kolumn bazując na wierpszym wierszu 
            // wplitujemy go po średnioku uzyskując tym sammy nową tablicę, której sprawdzamy długość 
            int liczbaKolumn = wiersze[0].Split(';').Length;

            // przygotowujemy tablićće o lizcibe wierszy o jeden mniejszeni bo nie chcemy nagłówka 
            string[,] tabDwuWym = new string[wiersze.Length - 1, liczbaKolumn];

            // idziemy po wszystkich kolumnach 
            for (int i = 1 ; i < wiersze.Length; i++)
            {
                // kazdy wiersz splitujemy po średniku żeby uzyskać talbicę komórek 
                string[] komorki = wiersze[i].Split(';');
                for (int j = 0; j < liczbaKolumn; j++) // idziemy po wszystkich komórkach 
                    tabDwuWym[i - 1, j] = komorki[j]; // uzupełniamy naszą tablicę dwu-wym.  wartością z j-tej komórki 
            }


            // tab tablic 
            string[][] tablicaTablic = new string[wiersze.Length - 1][];
            for (int i = 1  ; i < wiersze.Length; i++)
                tablicaTablic[i-1] = wiersze[i].Split(';');


            // moje zdanie jest takie, że tablice tablic są wygodniejsze niż tablice wielo wymiarowe 


            // listy list 
            List<List<string>> listaList = new List<List<string>>();
            for (int i = 1 ; i < wiersze.Length; i++)
                listaList.Add(wiersze[i].Split(';').ToList());
            




        }
    }
}
