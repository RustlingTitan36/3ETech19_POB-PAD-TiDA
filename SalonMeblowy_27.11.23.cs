using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IMebel
    {
        string Nazwa { get; set; }
        string Seria { get; set; }

        void WyswietlInformacje();
    }
    class MebleLazienkowe : IMebel
    {
        public string Nazwa { get; set; }
        public string Seria { get; set; }

        public MebleLazienkowe(string nazwa, string seria)
        {
            Nazwa = nazwa;
            Seria = seria;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Łazienka - Mebel: {Nazwa}, Seria: {Seria}");
        }
    }
    class MebleKuchenne : IMebel
    {
        public string Nazwa { get; set; }
        public string Seria { get; set; }

        public MebleKuchenne(string nazwa, string seria)
        {
            Nazwa = nazwa;
            Seria = seria;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Kuchnia - Mebel: {Nazwa}, Seria: {Seria}");
        }
    }

    class MebleDoPokoju : IMebel
    {
        public string Nazwa { get; set; }
        public string Seria { get; set; }

        public MebleDoPokoju(string nazwa, string seria)
        {
            Nazwa = nazwa;
            Seria = seria;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Pokój - Mebel: {Nazwa}, Seria: {Seria}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IMebel lazienka1 = new MebleLazienkowe("Szafka", "Jaśmin");
            IMebel kuchnia1 = new MebleKuchenne("Zabudowa lodówki", "Cytrynka");
            IMebel pokoj1 = new MebleDoPokoju("Sofa", "Piotr");

            IMebel lazienka2 = new MebleLazienkowe("Szafka pod zlew", "Połysk");
            IMebel kuchnia2 = new MebleKuchenne("Zabudowa piekarnika", "Pomarańczko");
            IMebel pokoj2 = new MebleDoPokoju("Szafa", "Kasia");

            IMebel lazienka3 = new MebleLazienkowe("Lustro", "Mat");
            IMebel kuchnia3 = new MebleKuchenne("Stół z hokerami", "Bananik");
            IMebel pokoj3 = new MebleDoPokoju("Komoda", " ");

            lazienka1.WyswietlInformacje();
            kuchnia1.WyswietlInformacje();
            pokoj1.WyswietlInformacje();

            lazienka2.WyswietlInformacje();
            kuchnia2.WyswietlInformacje();
            pokoj2.WyswietlInformacje();

            lazienka3.WyswietlInformacje();
            kuchnia3.WyswietlInformacje();
            pokoj3.WyswietlInformacje();
        }
    }
}
