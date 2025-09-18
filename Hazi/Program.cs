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
            string[] szavak = { "első", "alma", "vizibicigli", "kukac" };
            Random rnd = new Random();
            string szo = szavak[rnd.Next(szavak.Length)];
            int szohossz = szo.Length;
            int kitalatszo = 0;
            bool kilepo = false;
            int hiba = 10;;
            string szo2 = szo;
            Console.WriteLine(szo);
            do
            {
            Console.WriteLine($"A szó hossza: {szohossz} betű");
            Console.WriteLine($"Kitalálásra váró betűk {szo2.Length}");
            Console.WriteLine("Írj egy betűt:");
            char betu = Convert.ToChar(Console.ReadLine());
                if (szo2.Contains(betu))
                {
                    for (int i = 0; i < szo2.Length; i++)
                    {
                        if (szo2[i] == betu)
                        {
                            szo2=szo2.Remove(szo2.IndexOf(betu),1);
                            kitalatszo++;
                        }
                        
                    }
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
                    Console.WriteLine($"A szó: {szo} volt.");
                    kilepo = true;
                }
            }
            while (kilepo == false);
        }
    }
}
