﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grananje_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            switch (a)
            {
                case 1:
                    Console.WriteLine("jedan");
                    break;
                case 2:
                    Console.WriteLine("dva");
                    break;
                case 3:
                    Console.WriteLine("tri");
                    break;
                case 4:
                    Console.WriteLine("četiri");
                    break;
                default:
                    Console.WriteLine("Ništa što je veće od 4 ili negativno");
                    break;


            }

            if (a==4) Console.WriteLine(("JE"));
            else Console.WriteLine("Nije");

            switch (a == 4)
            {
                case true:
                    Console.WriteLine("JE");
                    break;
                case false:
                deafault:
                    Console.WriteLine("Nije");
                    break;
            }
            a = 12;
            switch (a)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Do 3");
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("4 do 6");
                    break;
                default:
                    Console.WriteLine("7 i više...");
                        break;

                case 12:
                    Console.WriteLine("12");
                    break;
            }

            int? b = null;
            switch (b)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Neka vrijednost");
                    break;
                case null:
                    Console.WriteLine("Nema vrijednosti, znači sve može!");
                    break;
                default:
                    Console.WriteLine("Ništa deseto!");break;
            }
            


        }
                
                
                
               
            }
        }
    

