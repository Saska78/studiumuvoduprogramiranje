/*
 * Program racuna opseg i povrsinu kruga, a trazi unos radijusa.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsegPovrsinaKruga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite radijus:");
            float r = float.Parse(Console.ReadLine());
            const float pi = 3.14f;
            float P, O;
            O = 2 * r * pi;
            P = r * r * pi;//P = r  * O /2;
            Console.WriteLine("Povrsina je "+P+"\nOpseg je"+O);
            Console.WriteLine();
            Console.ReadKey();


                
        }
    }
}
