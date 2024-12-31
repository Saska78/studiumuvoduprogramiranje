/*
 * Program ispisuje rješenje kvadratne jednadžbe za unesen a, b, c,
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kvadratna_jednadzba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Unesite a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Unesite b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Unesite c: ");
            c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0) Console.WriteLine("Jednadzba nema rjesenje!");
            else
            {
                d = Math.Sqrt(d);
                double x1, x2;
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine("x1=" + x1 + "\nx2=" + x2); ;
            }

        }
    }
}
            


    

