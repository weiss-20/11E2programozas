using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211001
{
    class Program
    {
        static void Main(string[] args)
        {
            // feladat1();
            // feladat2();
            // feladat6();
            feladat9();
            Console.WriteLine("enter");
            Console.ReadLine();
        }
        static void feladat1()
        {
            Console.WriteLine("Hello world!");
        }
        static void feladat2()
        {
            Console.Write("Kérem a neved! ");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia {0}!",nev);

        }
        static void feladat6()
        {
            Console.Write("Kérem a négyzet oldalát! a=");
            double a = double.Parse(Console.ReadLine());
            double k = 4 * a;
            Console.WriteLine("A négyzet kerülete {0}",k);
            double t = a * a;
            Console.WriteLine("A négyzet területe {0}",t);
            t = Math.Pow(a, 2);
            Console.WriteLine("A négyzet területe {0}",t);

        }
        static void feladat9()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            int legkisebb = Math.Min(a, Math.Min(b, c));
            Console.WriteLine("A három szám közül a legkisebb {0}", legkisebb);
        }
    }
}
