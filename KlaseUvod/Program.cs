﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseUvod
{
    class Osoba
    {
        //članovi (fields)
        public string Ime = "";
        public string Prezime = "";
        public DateTime DatumRodjenja;

        //konstruktori (constructors)
        public Osoba() { }
        public Osoba(string ime, string prezime, DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
        }

        //metode (methods)
        public int Dob()
        {
            return (DateTime.Now - DatumRodjenja).Days / 365;
        }
    }   
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba o1 = new Osoba();
            Osoba o2 = new Osoba("Nikola", "Tesla", DateTime.Parse("18.7.1856"));

            o1.Ime = "Marko";
            o1.Prezime = "Marulić";
            o1.DatumRodjenja = DateTime.Parse("18.8.1450");

            Console.WriteLine(o2.Ime + "" + o2.Prezime + "bi danas imao " + o2.Dob() + "godina");
;
        }
    }
}