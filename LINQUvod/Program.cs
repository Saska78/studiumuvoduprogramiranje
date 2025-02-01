using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQUvod
{
    public class Automobil
    {
        public int Id { get; set; }
        public string Proizvodjac { get; set; }
        public string Model { get; set; }
        public int Godiste { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Automobil> auti = new List<Automobil>();
            auti.Add(new Automobil { Id = 1, Proizvodjac = "Honda", Model = "Acord", Godiste = 2007 });
            auti.Add(new Automobil { Id = 2, Proizvodjac = "Ford", Model = "Mondeo", Godiste = 2010 });
            auti.Add(new Automobil { Id = 3, Proizvodjac = "VW", Model = "Golf", Godiste = 1987 });
            auti.Add(new Automobil { Id = 4, Proizvodjac = "Rimac", Model = "Nevera", Godiste = 2024 });

            //proizvođač modela acord;
            var proizvodjac = (from a in auti
                               where a.Model == "Acord"
                               select a.Proizvodjac).SingleOrDefault();
            Console.WriteLine("Našao sam da je "+proizvodjac+" proizveo traženi automobil.");

            var proizvodjac_opet = auti.Where(a => a.Model == "Acord").FirstOrDefault().Proizvodjac;
            Console.WriteLine(proizvodjac_opet);

            auti.Add(new Automobil { Id = 5, Proizvodjac = "Honda", Model = "Civic", Godiste = 2006 });
            auti.Add(new Automobil { Id = 6, Proizvodjac = "Ford", Model = "Focus", Godiste = 2001 });

            //var proizvodjac2 = (from a in auti
            //                 where a.Model == "Uno"
            //                    select a.Proizvodjac).Single();//nema elemenata!

            //var proizvodjac3 = (from a in auti
            //                  where a.Model.Contains("o")
            //                select a.Proizvodjac).Single(); //više elemenata!

            var proizvodjac2 = (from a in auti
                                where a.Model == "Uno"
                                select a.Proizvodjac).SingleOrDefault(); //nema elemenata!
            if(proizvodjac2 == null) Console.WriteLine("Nema rezultata!");

            //var proizvodjac3 = (from a in auti
            //                  where a.Model.Contains("o")
            //                    select a.Proizvodjac).SingleOrDefault();//više elemenata!
            //if(proizvodjac3 == null) Console.WriteLine("Konfliktni elementi!");
            //Console.WriteLine(proizvodjac);

            var proizvodjac3 = (from a in auti
                                where a.Model.Contains("o")
                                select a.Proizvodjac).First();//više elemenata!
            Console.WriteLine(proizvodjac3);

            var proizvodjac4 = (from a in auti
                                where a.Model.Contains("o")
                                select a.Proizvodjac).Last();//više elemenata!
            Console.WriteLine(proizvodjac4);

            var honda = (from a in auti
                         where a.Proizvodjac == "Honda"
                         select a).ToList();

            foreach(var a in honda)
            {
                Console.WriteLine(a.Proizvodjac+" "+a.Model);
            }

            var fordovi = (from a in auti
                           where a.Proizvodjac == "Ford"
                           select a).ToList();
        }
    }
}
