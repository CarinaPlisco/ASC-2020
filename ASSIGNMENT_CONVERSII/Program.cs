using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text;

namespace ASSIGNMENT_CONVERSII
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Conversia unui numar din baza n (<=2 || >=16) intr-o baza tinta. 
            Console.WriteLine("*****************************************");
            Console.WriteLine("*Conversie dintr-o baza n intr-o baza tinta*");
            Console.WriteLine("*****************************************");

               
            // Introducem numarul pe care vrem sa il convertim
            Console.WriteLine("Introduceti un numarul pe care vreti sa-l convertiti: ");
            // creati nume de identificatori expresivi
            string number;

            number = Console.ReadLine();

            /// introducem baza initiala
            Console.WriteLine("Introduceti baza initiala:");
            int baza;
            baza = int.Parse(Console.ReadLine());

            Dictionary<string, string> base16 = new Dictionary<string, string>();
            base16.Add("0000", "0");
            base16.Add("0001", "1");
            base16.Add("0010", "2");
            base16.Add("0011", "3");

            base16.Add("0100", "4");
            base16.Add("0101", "5");
            base16.Add("0110", "6");
            base16.Add("0111", "7");

            base16.Add("1000", "8");
            base16.Add("1001", "9");
            base16.Add("1010", "A");
            base16.Add("1011", "B");

            base16.Add("1100", "C");
            base16.Add("1101", "D");
            base16.Add("1110", "E");
            base16.Add("1111", "F");

            // TODO tratarea exceptiilor la introducerea numerelor


            // Introducem baza tinta
            string line;
            Console.WriteLine("Introduceti baza tinta (un numar natural intre 2 si 16):");
            line = Console.ReadLine();
            int bazaTinta;
            bazaTinta = int.Parse(Console.ReadLine());

           
            //  Console.WriteLine(base16["1110"]);
            // foreach(var item in base16.Keys)
            //  {
            //     Console.WriteLine($"{item} - {base16[item]}");
            //  }    
  
           
            int nrCifre = 0;

            switch(baza)
            {
                case 4:
                    nrCifre = 2;
                    break;
                case 8:
                    nrCifre = 3;
                    break;
                case 16:
                    nrCifre = 4;
                    break;
                default:
                    Console.WriteLine("Baza tinta nu este corecta!");
                    throw new InccorectBaseException();
                    break;
            }

            int lungimeNrB2;
            lungimeNrB2 = number.Length;

            int nrZerouriDeAdaugat;

            if(nrZerouriDeAdaugat % nrCifre > 0)
            {
                nrZerouriDeAdaugat = nrCifre - lungimeNrB2 % nrCifre;
            }



            }
        }
    }
