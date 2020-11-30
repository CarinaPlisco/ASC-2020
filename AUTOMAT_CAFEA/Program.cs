using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTOMAT_CAFEA
{
    class Program
    {

       // variabilele
       static int coins = 0;
       static int rest = 0;
       static char c = '0';

       static void Main(string[] args)
        {
            A();
        }
       private static void Write()
        {
            Console.WriteLine($" Sunt {coins} centi in automat. ");
            Console.WriteLine("Ce tip de moneda vei introduce? ");
            Console.WriteLine("N - Nickel");
            Console.WriteLine("D - Dime");
            Console.WriteLine("Q - Quarter");
        }
       //cazul A
       private static void A()
        {
            if (coins < 20)
            {
                Write();
                GetCoins();
                switch (c)
                {
                    case 'N':
                        coins += 5;
                        B();
                        break;
                    case 'D':
                        coins += 10;
                        C();
                        break;
                    case 'Q':
                        coins += 25;
                        A();
                        break;
                    default:
                        Console.WriteLine("Va rugam reintroduceti moneda. ");
                        A();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Va rugam ridicati produsul.");
                rest = coins - 20;
                if (rest > 0)
                    Rest();
            }
        }
       //RESTUL
        private static void Rest()
        {
            coins -= 20;
            switch (rest)
            {
                case 5:
                    Console.WriteLine("Restul dvs este de 1 nickel");
                    coins -= 5;
                    break;
                case 10:
                    Console.WriteLine("Restul dvs este de 1 dime");
                    coins -= 10;
                    break;
                case 15:
                    Console.WriteLine("Restul dvs este de 1 nickel si un dime");
                    coins -= 15;
                    break;
                case 20:
                    Console.WriteLine("Restul dvs este de 1 nickel si un dime");
                    B();
                    break;
                default:
                    break;
            }
        }
       //cazul D
       private static void D()
            {
                Console.WriteLine("STAREA D");
                Write();
                GetCoins();
                switch (c)
                {
                    case 'N':
                        coins += 5;
                        A();
                        break;
                    case 'D':
                        coins += 10;
                        A();
                        break;
                    case 'Q':
                        coins += 25;
                        B();
                        break;
                    default:
                        Console.WriteLine("Va rugam reintroduceti moneda. ");
                        D();
                        break;
                }
       }
       //cazul C
       private static void C()
       {
                Console.WriteLine("STAREA C");
                Write();
                GetCoins();
                switch (c)
                {
                    case 'N':
                        coins += 5;
                        D();
                        break;
                    case 'D':
                        coins += 10;
                        A();
                        break;
                    case 'Q':
                        coins += 25;
                        A();
                        break;
                    default:
                        Console.WriteLine("Va rugam reintroduceti moneda. ");
                        C();
                        break;
                }
       }
       //cazul B
       private static void B()
        {
            Console.WriteLine("STAREA B");
            if (coins <= 20)
            {

                Write();
                GetCoins();
                switch (c)
                {
                    case 'N':
                        coins += 5;
                        C();
                        break;
                    case 'D':
                        coins += 10;
                        D();
                        break;
                    case 'Q':
                        coins += 25;
                        A();
                        break;
                    default:
                        Console.WriteLine("Va rugam reintroduceti moneda. ");
                        B();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Ati primit produsul");
                rest = coins - 20;
                if (rest > 0) Rest();
            }
        }
       private static void GetCoins()
       {
            c = char.Parse(Console.ReadLine());
            Console.Clear();
       }
    }
}


