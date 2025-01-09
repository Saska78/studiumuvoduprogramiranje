using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enkapsulacija
{
    public class Osoba
    {
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        } 

        public string ImePrezime
        {
            get { return ime + "" + prezime; }

  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
