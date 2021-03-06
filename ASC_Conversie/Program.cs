﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASC_Conversie
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Conversia unui numar din baza n intr-o baza tinta. 

            Console.WriteLine("*****************************************");
            Console.WriteLine("*Conversie din baza n intr-o baza tinta*");
            Console.WriteLine("*****************************************");

            Console.WriteLine("Introduceti un numar in baza 2: ");
            string number2;

            number2 = Console.ReadLine();

            Console.WriteLine("introduceti baza in care vreti sa faceti conversia (4,8,16)");
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

            Dictionary<string, string> base8 = new Dictionary<string, string>();
            base8.Add("000", "0");
            base8.Add("001", "1");
            base8.Add("010", "2");
            base8.Add("011", "3");

            base8.Add("100", "4");
            base8.Add("101", "5");
            base8.Add("110", "6");
            base8.Add("111", "7");

            Dictionary<string, string> base4 = new Dictionary<string, string>();
            base4.Add("00", "0");
            base4.Add("01", "1");
            base4.Add("10", "2");
            base4.Add("11", "3");

            int nrCifre = 0;
            switch (baza)
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
            }
            int lungimeNrB2;
            lungimeNrB2 = number2.Length;

            int nrZerouriDeAdaugat = 0;
            if (lungimeNrB2 % nrCifre > 0)
            {
                nrZerouriDeAdaugat = nrCifre - lungimeNrB2 % nrCifre;
            }
            number2 = number2.PadLeft(nrZerouriDeAdaugat + lungimeNrB2, '0');

            StringBuilder sb = new StringBuilder();
            int i = 0;
            string key;
            while (i < number2.Length / nrCifre)
            {
                key = number2.Substring(i * nrCifre, nrCifre);
                switch(baza)
                {
                    case 4:
                        sb.Append(base4[key]);
                        break;
                    case 8:
                        sb.Append(base4[key]);
                        break;
                    case 16:
                        sb.Append(base4[key]);
                        break;
                }
                i++;

            }
            string result = sb.ToString();

            Console.WriteLine(result);


            // creati nume de identificatori expresivi
            string line;


            // Introducem numarul in baza 10 pe care vrem sa il convertim
            Console.WriteLine("Introduceti numarul in baza 10 pe care vreti sa-l convertiti: ");
            line = Console.ReadLine();
            int numar;
            numar = int.Parse(line);


            // Introducem baza tinta
            Console.WriteLine("Introduceti baza tinta (un numar natural intre 2 si 16):");
            line = Console.ReadLine();
            int bazaTinta;
            bazaTinta = int.Parse(line);



            // TODO trebuie sa ne asiguram ca numarul introdus ca si baza tinta este intre 2 si 16

            int cat, rest;

            string result2 = "";
            Stack<int> stiva = new Stack<int>();

            while (numar > 0)
            {
                cat = numar / bazaTinta;
                rest = numar % bazaTinta;

                stiva.Push(rest);

                numar = numar / bazaTinta;
            }


            // TODO afisarea corecta a cifrelor atunci cand baza tinta e mai mare decat 10
            while (stiva.Count > 0)
            {
                result2 = result2 + stiva.Pop();
            }

            Console.WriteLine(result2);
        }


    }
}
