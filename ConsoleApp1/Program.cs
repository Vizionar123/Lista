using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista1 = new List<int>();
            string unos;
            double rezultat=0;
            do
            {
               
                Console.Write("Unesite broj/Za obustavu pritisnite Enter : ");
                unos = Console.ReadLine();
                if (unos!="")
                {lista1.Add(int.Parse(unos)); };
            } while (unos != "");
            if (lista1.Count != 0)
            {
                rezultat = Prosek(lista1);
                Console.WriteLine("Prosecna vrednost unetih brojeva je : {0:#.##}", rezultat);
            }
            else
            {
                Console.WriteLine("Nije moguce napraviti proracun!!!");
            }
            Console.ReadKey();
        }
        public static double Prosek(List<int>lista1)
        {
           double p,s;
            int i;
           
            i = 0;
            s = 0;
        foreach(int n in lista1)
            {
                s = s + n;
                i = i + 1;//lista1.Count
                
            }
            p = s / i;
           

            return (p);
        }
    }
}
