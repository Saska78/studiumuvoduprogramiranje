using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ugnjezdivanje_petlji
{
    internal class Program
    {
        private static int j;

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++);
                {
                    Console.Write(i * j);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}
//Keep it simple = KIS
