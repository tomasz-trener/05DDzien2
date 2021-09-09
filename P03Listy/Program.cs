using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03Listy
{
    class Program
    {
        static void Main(string[] args)
        {
            //    string[] tablica = new string[2];
            //   tablica[2] = "ala";
            // głównym ograniczenim tablic jest to, że mają one stałą długość

            //listy to takie tablice, które dynamicznie mogą zeminiać swój rozmiar 

            List<string> imiona = new List<string>();
            List<int> liczby = new List<int>();

            int ile = imiona.Count;

            //dodanie nowego elementu

            liczby.Add(5);
            liczby.Add(7);
            imiona.Add("ala");

            // liczby[2] = 5; w ten sposób nie mozmey dodwac nowych elementow 

            liczby.Insert(1, 2); // wstawieine 
            //na konkretną pozycje 

            // edycja 
            liczby[1] = 9;

            // usuwanie 

            // liczby.Remove(5); // usuwa pierwszą 5 od początku
            liczby.RemoveAt(1); // usuwam drugi od początku element 

            //jak usunać ostatni lement? 
            liczby.RemoveAt(liczby.Count - 1); // usuniecie ostatniego elementu 

            //liczby.RemoveAll() 

            // tablice są szybsze 


            // szukam liczby 2 w tablicy/liście 
            // ten sposób pokaze ostatnie wystapienie 
            //int indeks=0;
            //for (int i = 0; i < liczby.Count; i++)
            //    if (liczby[i]==2)
            //        indeks = i;

            // szukam liczby 2 , pierwsze wystapienie 
            //int indeks = 0;
            //for (int i = 0; i < liczby.Count; i++)
            //    if (liczby[i] == 2)
            //    {
            //        indeks = i;
            //        break; // natychmiast wyjdz z pętli 
            //    }

            // znajdz wszystkie wystąpienia liczby 2 
            List<int> indeksy = new List<int>();
            for (int i = 0; i < liczby.Count; i++)
                if (liczby[i] == 2)
                    indeksy.Add(i);


            int indeks2= liczby.IndexOf(2); // ta metoda pokaze pierwse wystapienie


       




        }
    }
}
