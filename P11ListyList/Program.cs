using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ListyList
{
    class Program
    {
        static void Main(string[] args)
        {
            // dlaczego listy list ? 

            // mamy tablice wielowymiarowe 
            // ale nie mamy list wielowymiarowych 

            // mamy tablice postrzepione 
            // wg. mnie lepsza nazwa to tablica tablic 

            // w przypadku list , możemy utowrzyć listę list 

            List<List<int>> glownaLista = new List<List<int>>();

            glownaLista.Add(new List<int>());
            glownaLista[0].Add(1);
            glownaLista[0].Add(2);
            glownaLista[0].Add(3);

            glownaLista.Add(new List<int>());
            glownaLista[1].Add(4);

            List<int> wewnetrznaListaOstatnia = new List<int>();
            wewnetrznaListaOstatnia.Add(5);
            wewnetrznaListaOstatnia.Add(6);
            glownaLista.Add(wewnetrznaListaOstatnia);
            
            //glownaLista.Add(new List<int>());
            //glownaLista[2].Add(5);
            //glownaLista[2].Add(6);




        }
    }
}
