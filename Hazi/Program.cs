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
            string[] szavak = { "első", "alma", "vizibicigli", "kukac", "Péter", "" };
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
            do
            {
            Console.WriteLine($"A szó hossza: {szohossz} betű");
            Console.WriteLine($"Kitalálásra váró betűk {szo2.Length}");
            Console.WriteLine(kitalalt);
            Console.WriteLine("Írj egy betűt:");
            char betu = Convert.ToChar(Console.ReadLine());
                if (szo2.Contains(betu))
                {
                    for (int i = 0; i < szo2.Length; i++)
                    {
                        if (szo2[i] == betu)
                        {
                            
                            kitalatszo++;
                            kitalalt[i] = betu;
                           
                        }
                        
                    }
                    szo2=szo2.Replace(betu,'*');
                    Console.WriteLine("Eltaláltad a betüt.");
                }
                else
                {
                    hiba--;
                    Console.WriteLine("Nem találtad el.");
                    Console.WriteLine($"Még {hiba} próbálkozásod van");
                }
                if (kitalatszo == szohossz)
                {
                    Console.Clear();
                    Console.WriteLine("Kitaláltad a szót.");
                    Console.WriteLine($"A szó {szo} volt.");
                    kilepo = true;
                }
            }
            while (kilepo == false);
        }
    }
}
