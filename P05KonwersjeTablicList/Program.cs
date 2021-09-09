using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05KonwersjeTablicList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t1 = { 1, 2, 3 };

            // chcę zaminić tę tablicę na listę 

            List<int> lista1 = t1.ToList();

            // gdymym znowu chcaił tę liste przekonwertować na tablice 
            int[] t2 = lista1.ToArray();

            // gdybym chciał wypisać wszystkie elementu tablicy/listy (kolekcji) do zmiennej string,
            // zeby wypisac je na ekran 

            // w poejsciu "tradycyjnym" musze uzyc petli 

            string wynik = "";
            for (int i = 0; i < t2.Length; i++)
                wynik += Convert.ToString(t2[i]) + " ";

            Console.WriteLine(wynik) ;

            // krócej mozna uzyc polecenia string.join

            string wynik2 = string.Join(" ", t2);

            Console.WriteLine(wynik2);


        }
    }
}
