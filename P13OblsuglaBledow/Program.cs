using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13OblsuglaBledow
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 01; // to może byc wartośc z konosli , zpliku lub z innego zewnętrznego źrodła 

            // kod niebezpieczny to taki, pochodzi z zewnętrznego źródła czyli:
            // pliki, baza danych , konsola , api , inna strona 

            string[] t = new string[2];

            try
            {
                double c = a / b;
                t[3] = "4";
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("próbujesz dzielić przez 0");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("próbujesz odowłaćsię do elementu, który wykracza poza zakres twoich danych");
            }
            catch (Exception)
            {
                Console.WriteLine("wystąpił jakiś bład");
            }
            finally
            {
                Console.WriteLine("to ma się wykonć zawsze ");
            }

            Console.ReadKey();
            




        }
    }
}
