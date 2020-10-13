using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_MOORE
{
    class Program
    {
        static void Main(string[] args)
        {
            string consol;
            double cateOri;
            while (true)
            {
                Console.WriteLine("Introduceti un numar natural pentru a calcula perioada de timp in care puterea de calcul devine de n ori mai mare decat in momentul prezent: ");
                consol = Console.ReadLine();
                if (double.TryParse(consol, out cateOri))
                {
                    double ani;
                    ani = 1.5 * Math.Log(cateOri, 2);
                    Console.WriteLine("Puterea de calcul va fi mai mare de {0} ori in {1} ani", cateOri, ani);
                    break;
                }
                else
                {
                    Console.WriteLine("Introduceti un numar pentru a calcula perioada de timp: ");
                    Console.WriteLine("");
                }
            }
        }
    }
}
