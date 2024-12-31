//Učitati 4 broja,ispisati onaj koji ima najveću sumu znamenki
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajveceSumeZnamenki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj;
            for (int i = 0; i < 4; i++) ;
            {
                Console.Write("Unesite [0]. broj: ", i + 1);
                broj = int.Parse(Console.ReadLine());

                int pom = broj;
                int sum = 0;
                while(pom > 0)
                    {
                    sum = sum + pom % 10;
                    pom = pom / 10;
                }

                if(sum>trazena_suma)
                {
                    trazena_suma = sum;
                    trazeni_broj = broj;
                }
            }
        }
    }
}
