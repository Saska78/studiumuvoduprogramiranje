using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Suma_prvih_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 100; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            
        }
        
    }
}
