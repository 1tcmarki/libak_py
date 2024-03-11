using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Kiir(int[] t,string cim) {
            Console.WriteLine(cim);
            foreach (int suly in t)
            {
                Console.Write($"{suly}");
            }
        
        }
        static void Main(string[] args)
        {

            int[] libak = { 1, 5, 2, 3, 4 };
            Kiir(libak,"libak sulyai");
            Console.WriteLine("gomb");
            Console.ReadKey();
        }
    }
}
