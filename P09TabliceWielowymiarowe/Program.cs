using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09TabliceWielowymiarowe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabJednoWym = new int[3];

            int[,] tabDwuWym = new int[3, 2];
            int[,,] tabTrzyWym = new int[3, 2, 4];

            // domyslne wartości tak jak w tab jedno wym
            // w przypadku int =0

            tabDwuWym[0, 0] = 1;
            tabDwuWym[1, 0] = 2;
            tabDwuWym[2, 0] = 3;

            tabDwuWym[0, 1] = 4;
            tabDwuWym[1, 1] = 5;
            tabDwuWym[2, 1] = 6;

            for (int i = 0; i < tabDwuWym.GetLength(0); i++)
            {
                for (int j = 0; j < tabDwuWym.GetLength(1); j++)
                    Console.Write(tabDwuWym[i,j]);
                Console.WriteLine();
            }

            Console.WriteLine("-------");

            for (int i = 0; i < tabDwuWym.GetLength(1); i++)
            {
                for (int j = 0; j < tabDwuWym.GetLength(0); j++)
                    Console.Write(tabDwuWym[j, i]);
                Console.WriteLine();
            }
            Console.ReadKey();



        }
    }
}
