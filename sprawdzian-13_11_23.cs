using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Stacja
    {
        public string Nazwa { get; set; }
    }
    class Polaczenia
    {
        public Polaczenia (Stacja stacja1, Stacja stacja2, Pociag pociag)
        {
            stacja1 = new Stacja();
            stacja2 = new Stacja();
            pociag = new Pociag();
        }
        public void wypisz(Stacja stacja1, Stacja stacja2, Pociag pociag)
        {
            if (pociag.IloscMiejsc1 == 0)
            {
                if (pociag.IloscMiejsc2 == 0)
                {
                    Console.WriteLine("Nie ma przejazdu: od " + stacja1.Nazwa + " do " + stacja2.Nazwa);
                }
                else if(pociag.IloscMiejsc2 > 0)
                {
                    Console.WriteLine("Z " + stacja1.Nazwa + " do " + stacja2.Nazwa + " Ceny: Klasa 2 - " + pociag.StawkaKlasa2 + "zł.");
                }
            }
            else if (pociag.IloscMiejsc1 > 0)
            {
                if (pociag.IloscMiejsc2 == 0)
                {
                    Console.WriteLine("Z " + stacja1.Nazwa + " do " + stacja2.Nazwa + " Ceny: Klasa 1 - " + pociag.StawkaKlasa1 + "zł.");
                }
                else if (pociag.IloscMiejsc2 > 0)
                {
                    Console.WriteLine("Z " + stacja1.Nazwa + " do " + stacja2.Nazwa + " Ceny: Klasa 1 - " + pociag.StawkaKlasa1 + "zł. Klasa 2 - " + pociag.StawkaKlasa2 + "zł.");
                }
            }
        }
    }
    class Pociag
    {
        public int IloscMiejsc1 { get; set; }
        public int IloscMiejsc2 { get; set; }
        public int StawkaKlasa1 { get; set; }
        public int StawkaKlasa2 { get; set; }
        public void DajGlos(string glos)
        {
            Console.WriteLine(glos);
        }
    }
    interface ITramwaj
    {
        void DajGlos();
    }
    class Adapter : ITramwaj
    {
        private Pociag pociag;
        public Adapter(Pociag pociag)
        {
            this.pociag = pociag;
        }
        public void DajGlos()
        {
            pociag.DajGlos("dzyń dzyń");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stacja stacja1 = new Stacja();
            stacja1.Nazwa = "Szczecin";
            Stacja stacja2 = new Stacja();
            stacja2.Nazwa = "Poznań";
            Stacja stacja3 = new Stacja();
            stacja3.Nazwa = "Kraków";
            Stacja stacja4 = new Stacja();
            stacja4.Nazwa = "Szczawnica";

            Pociag pociag1 = new Pociag();
            pociag1.IloscMiejsc1 = 1;
            pociag1.IloscMiejsc2 = 1;
            pociag1.StawkaKlasa1 = 150;
            pociag1.StawkaKlasa2 = 70;
            Pociag pociag2 = new Pociag();
            pociag2.IloscMiejsc1 = 1;
            pociag2.IloscMiejsc2 = 0;
            pociag2.StawkaKlasa1 = 200;
            pociag2.StawkaKlasa2 = 0;
            Pociag pociag3 = new Pociag();
            pociag3.IloscMiejsc1 = 0;
            pociag3.IloscMiejsc2 = 0;
            pociag3.StawkaKlasa1 = 0;
            pociag3.StawkaKlasa2 = 0;

            Polaczenia polaczenie1 = new Polaczenia(stacja1, stacja2, pociag1);
            Polaczenia polaczenie2 = new Polaczenia(stacja2, stacja3, pociag2);
            Polaczenia polaczenie3 = new Polaczenia(stacja3, stacja4, pociag3);
            polaczenie1.wypisz(stacja1, stacja2, pociag1);
            polaczenie2.wypisz(stacja2, stacja3, pociag2);
            polaczenie3.wypisz(stacja3, stacja4, pociag3);

            ITramwaj tramwaj = new Adapter(pociag1);
            pociag1.DajGlos("ciuuuu");
            tramwaj.DajGlos();

            Console.ReadKey();
        }
    }
}
