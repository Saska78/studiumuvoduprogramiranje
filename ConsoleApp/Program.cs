﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, brojac = 0;
            int broj;
            do
            {
                Console.Write("Unesite broj:");
                broj = int.Parse(Console.ReadLine());
                if (broj != 0)
                {
                    sum += broj;
                    brojac ++;
                }

            } while (broj!=0);

            Console.WriteLine("Prosjek svih brojeva je");
            }
        }
    }

