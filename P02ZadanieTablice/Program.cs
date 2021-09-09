using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ZadanieTablice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile imion chcesz przechowywać");
            int ile = Convert.ToInt32(Console.ReadLine());

            string[] imiona = new string[ile];

            Console.WriteLine("Zacznij podawać imiona i zaakceptuj ENTER");

            for (int i = 0; i < ile; i++)
                imiona[i] = Console.ReadLine();

            // teraz bezdiemy wypisywac imiona 

            for (int i = 0; i < ile; i++)
            {
                string wynik = String.Format("{0} ({1})", imiona[i], imiona[i].Length);
                Console.WriteLine(wynik);
            }
            Console.ReadKey();


        }
    }
}
