﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] polje = new int[10];

            int[] brojevi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };

            float[] decimalni_brojevi = { 3.14f, 7.22f, 0.99f };

            char[] rijec = { 'R', 'i', 'j', 'e', 'č' };

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(brojevi[i]);
            }

            //Console.WriteLine(brojevi[12]);

            brojevi[7] = 50432;
            Console.WriteLine();

            for (int i = 0; i < 10; i++) ;
            {
                Console.WriteLine(brojevi[i]);
            }

            Console.WriteLine("Broj elemenata u brojevi


        }
    }
}
