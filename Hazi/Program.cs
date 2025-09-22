using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Hazi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] szavak = { "első", "alma", "vizibicigli", "kukac", "reaktor"};
            Random rnd = new Random();
            string szo = szavak[rnd.Next(szavak.Length)];
            int szohossz = szo.Length;
            int kitalatszo = 0;
            bool kilepo = false;
            int hiba = 10;;
            string szo2 = szo;
            char[] kitalalt = new char[szo.Length];
            for (int i = 0; i < kitalalt.Length; i++)
            {
                kitalalt[i] = '_';
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*****AKASZTÓFA*****");
            
            do
            {
            Console.WriteLine($"Még {hiba} próbálkozásod van");
            Console.WriteLine($"A szó hossza: {szohossz} betű");
            Console.WriteLine(kitalalt);
            Console.WriteLine("Írj egy betűt:");
            char betu = Convert.ToChar(Console.ReadLine());
                if (szo2.Contains(betu))
                {
                    Eltalatad(ref kitalatszo, ref szo2, kitalalt, betu);
                }
                else
                {
                    hiba--;
                    Console.Clear();
                    Console.WriteLine("*****AKASZTÓFA*****");
                    Console.WriteLine("Nem találtad el.");
                    
                }
                if (kitalatszo == szohossz)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("*****AKASZTÓFA*****");
                    Console.WriteLine("Kitaláltad a szót.");
                    Console.WriteLine($"A szó {szo} volt.");
                    kilepo = true;
                }
                if (hiba == 0)
                {
                    Console.Clear();
                    Console.WriteLine("*****AKASZTÓFA*****");
                    Console.WriteLine("Vesztettél.");
                    Console.WriteLine($"A szó {szo} volt.");
                    kilepo = true;
                }
            }
            while (kilepo == false);
        }

        private static void Eltalatad(ref int kitalatszo, ref string szo2, char[] kitalalt, char betu)
        {
            for (int i = 0; i < szo2.Length; i++)
            {
                if (szo2[i] == betu)
                {

                    kitalatszo++;
                    kitalalt[i] = betu;

                }

            }
            szo2 = szo2.Replace(betu, '*');
            Console.Clear();
            Console.WriteLine("*****AKASZTÓFA*****");
            Console.WriteLine("Eltaláltad a betüt.");
        }
    }
}
