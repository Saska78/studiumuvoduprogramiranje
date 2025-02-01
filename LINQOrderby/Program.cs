using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOrderby
{
    class Osoba
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godina_rodjenja { get; set; }

        public override string ToString()
        {
            return Id.ToString() + " " + Ime + " " + Prezime + " " + Godina_rodjenja.ToString();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Osoba> osobe = new List<Osoba>();
            osobe.Add(new Osoba { Id = 1, Ime = "Nikola", Prezime = "Tesla", Godina_rodjenja = 1856 });
            osobe.Add(new Osoba { Id = 2, Ime = "Issac", Prezime = "Newton", Godina_rodjenja = 1643 });
            osobe.Add(new Osoba { Id = 3, Ime = "Alfred", Prezime = "Nobel", Godina_rodjenja = 1833 });
            osobe.Add(new Osoba { Id = 4, Ime = "Max", Prezime = "Planck", Godina_rodjenja = 1858 });
            osobe.Add(new Osoba { Id = 5, Ime = "Albert", Prezime = "Einstein", Godina_rodjenja = 1879 });
            osobe.Add(new Osoba { Id = 6, Ime = "Robert", Prezime = "Openheimer", Godina_rodjenja = 1904 });
            osobe.Add(new Osoba { Id = 7, Ime = "Stephen", Prezime = "Hawking", Godina_rodjenja = 1942 });
            osobe.Add(new Osoba { Id = 8, Ime = "Alan", Prezime = "Turing", Godina_rodjenja = 1912 });

            Console.WriteLine("Originalna lista: ");
            foreach(var o in osobe) Console.WriteLine(o);

            Console.WriteLine();
            Console.WriteLine("Sortiranje po godini rođenja");
            var sortiraj_godine = (from o in osobe
                                   orderby o.Godina_rodjenja
                                   select o).ToList();
            foreach(var o in sortiraj_godine) Console.WriteLine(o);
            Console.WriteLine();
            sortiraj_godine = (from o in osobe
                                orderby o.Godina_rodjenja descending
                                select o).ToList();
            foreach(var o in sortiraj_godine) Console.WriteLine(o);

            Console.WriteLine();
            Console.WriteLine("Sortiranje po prezimenu,pa po imenu: ");
            var sort_prezime = (from o in osobe
                                orderby o.Prezime ascending, o.Ime descending
                                select o).ToList();
            foreach(var o in sort_prezime)Console.WriteLine(o);
            
            Console.WriteLine();
            Console.WriteLine("Svi rođeni u 19. stoljeću, sortirani po imenu:");
            var osamstote = (from o in osobe
                             where o.Godina_rodjenja >= 1800 && o.Godina_rodjenja < 1900
                             orderby o.Ime
                             select o).ToList();
            foreach(var o in osamstote) Console.WriteLine(o);

            osamstote = osobe.Where(o => o.Godina_rodjenja >= 1800 &&
                            o.Godina_rodjenja < 1900).OrderBy(o => o.Ime).ToList();
            Console.WriteLine();
            foreach(var o in osamstote) Console.WriteLine(o);

            Console.WriteLine();
            Console.WriteLine("Osobe čije ime počinje s N, sortirani silazno po prezimenu");
            var n = (from o in osobe
                     where o.Ime.StartsWith("N") || o.Ime[0] == 'N' || o.Ime.Substring(0, 1) == "N"
                     orderby o.Prezime descending
                     select o).ToList();
            foreach(var o in n) Console.WriteLine(o);
        }
    }
}
