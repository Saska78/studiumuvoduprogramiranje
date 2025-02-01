using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace JSONUvod
{
    class Zaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var zap = new Zaposlenik()
            {
                Ime = "Nikola",
                Prezime = "Tesla",
                DatumRodjenja = new DateTime(1856, 7, 10)
            };

            string json = JsonSerializer.Serialize(zap);

            Console.WriteLine(json);

            File.WriteAllText("zaposlenik.json", json);


            Zaposlenik z = JsonSerializer.Deserialize<Zaposlenik>(json);
            Console.WriteLine(z.Ime+" "+z.Prezime+" "+z.DatumRodjenja.ToShortDateString());


        }
    }
}
