using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseAutomobil
{
    public class Automobil
    {
        //članovi
        #region Members

        int masa;
        int duzina;
        int sirina;
        int visina;
        int snaga;
        int km;
        string marka;
        int godinaProizvodnje;
        string boja;

        Rendregion
        
        //svojstva
        region Properties
       public int Masa
        {
            get { return masa; }
            set { masa = value; }
        }

        public int Duzina
        {
            get { return duzina; }
            set { duzina = value; }
        }

        public int Sirina
        {
            get { return sirina; }
            set { sirina = value; }
        }

        public int Visina
        {
            get { return visina; }
            set { visina = value; }
        }

        public int SnagaKS
        {
            get { return (int)(snaga * 1.3); }
            set { snaga = (int)((double)value / 1.3); }
        }

        public int Km
        {
            get { return km; }
        }

        public string Marka
        {
            get { return marka; }
            private set {
                string vrijednost = value;
                if(string.IsNullOrEmpty(marka)) marka
                
            



        //konstruktori
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
