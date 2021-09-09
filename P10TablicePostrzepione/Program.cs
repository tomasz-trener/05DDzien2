using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10TablicePostrzepione
{
    class Program
    {
        static void Main(string[] args)
        {
            // tablica postrzępiona (jagged array) 

            // każdy wiersz może mieć inną liczbę komórek 

            // oczywiście dotyczy to także innych wymiarów np. 3,4,5....

            int[,] tabDwuWymiarowa = new int[2, 3];

            int[][] tabPostrzepiona = new int[4][];



            tabPostrzepiona[0] = new int[2];
            tabPostrzepiona[1] = new int[3];
            tabPostrzepiona[2] = new int[1];
            tabPostrzepiona[3] = new int[4];

            tabPostrzepiona[0][0] = 1;
            tabPostrzepiona[0][1] = 2;

            tabPostrzepiona[1][0] = 3;
            tabPostrzepiona[1][1] = 4;
            tabPostrzepiona[1][2] = 5;

            tabPostrzepiona[2][0] = 6;

            tabPostrzepiona[3][0] = 7;
            tabPostrzepiona[3][1] = 8;
            tabPostrzepiona[3][2] = 9;
            tabPostrzepiona[3][3] = 10;







        }
    }
}
