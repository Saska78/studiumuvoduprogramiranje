using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrananjeIF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4, b = 5;

            if (a<4) Console.WriteLine("a je manji od 4");
            if (a==4) Console.WriteLine("a je jednak 4");
            if (a > 4) Console.WriteLine("a je veci od 4");

                    if(a > b) Console.WriteLine("a je veci od b");

            if(a > b);
            {
                Console.WriteLine("a je manji od b");
                Console.WriteLine("a moramo povecati da ne bude vise manji");
                Console.WriteLine("no b mora u tom slucaju ostati isti");
            }


        }
    }
}
