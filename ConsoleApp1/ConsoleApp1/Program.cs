using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void kiir(int[] t, string cim)
        {
            Console.WriteLine(cim);
            foreach (int szam in t)
            {
                Console.Write($"{szam}, ");
            }
            Console.WriteLine();
        }

        static int Osszegez(int[] t)
        {
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 3)
                {
                    osszeg += t[i];
                }
            }
            return osszeg;
        }

        static double Atlagol(int[] t)
        {
            int osszeg = 0;
            int db = 0;
            foreach (int elem in t)
            {
                if (elem > 3)
                {
                    osszeg += elem;
                    db++;
                }
            }
            if (db == 0)
            {
                return 0;
            }
            return (double)osszeg / db;
        }

        static void kiir_eredmeny(int roka_libai)
        {
            Console.WriteLine($"amit a roka ellopott osszesen : {roka_libai} kg.");
        }

        static void kiir_atlag(double atlag)
        {
            Console.WriteLine($"Az atlag maradek liba {atlag}. kg.");
        }

        static void Main(string[] args)
        {
            int[] libak = { 1, 5, 2, 3, 4 };
            kiir(libak, "libák súlyai");
            int hany_kilo_libat_ehet_meg_a_roka = Osszegez(libak);

            kiir_eredmeny(hany_kilo_libat_ehet_meg_a_roka);

            double atlag_suly = Atlagol(libak);
            kiir_atlag(atlag_suly);

            Console.WriteLine("Nyomja meg a billentyűt a kilépéshez");
            Console.ReadKey(true);
        }
    }
}