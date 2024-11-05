using Projektas_11_04.Core.Models;
// Darbuotojai ir algu skaiciavimas
namespace Projektas_11_04
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Programuotojas programuotojas1 = new Programuotojas("Jonas", 39911191234, 1231231);
            Programuotojas programuotojas2 = new Programuotojas("Tadas", 39901221244, 1200231);
            Vadybininkas vadybininkas1 = new Vadybininkas("Juozas", 39901221214, 99000);
            Vadybininkas vadybininkas2 = new Vadybininkas("Darius", 39101221214, 110000);

            List<Darbuotojas> visiDarbuotojai = new List<Darbuotojas>();

            visiDarbuotojai.Add(programuotojas1);
            visiDarbuotojai.Add(programuotojas2);
            visiDarbuotojai.Add(vadybininkas1);
            visiDarbuotojai.Add(vadybininkas2);
            // pradinis atlyginimas
            Console.WriteLine("Pradinis atlyginimas");
            foreach (Darbuotojas d in visiDarbuotojai)
            {
                Console.WriteLine($"{d.Vardas}, {d.BazinisAtlyginimas}");
            }
            SkaiciuotiAtlyginima(visiDarbuotojai);
            // pakeistas atlyginimas
            Console.WriteLine("Pakeistas atlyginimas");
            foreach (Darbuotojas d in visiDarbuotojai)
            {
                Console.WriteLine($"{d.Vardas}, {d.BazinisAtlyginimas}");
            }
        }
        public static void SkaiciuotiAtlyginima(List<Darbuotojas> visiDarbuotojai)
        {
            foreach (Darbuotojas d in visiDarbuotojai)
            {
                if ( d is Programuotojas)
                {
                    d.BazinisAtlyginimas *= 1.2;

                } else if (d is Vadybininkas)
                {
                    d.BazinisAtlyginimas *= 1.1;

                }
            }
        }
    }
}
