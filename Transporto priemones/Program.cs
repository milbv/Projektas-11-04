using System;
using Transporto_priemones.Core.Models;

namespace Transporto_priemones
    //Transporto priemones ir kuro apskaiciavimas
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<TransportoPriemone> visasTransportas = new List<TransportoPriemone>();

            Automobilis automobilis1 = new Automobilis("Kia", 5.2);
            Automobilis automobilis2 = new Automobilis("Skoda", 6);
            Motociklas motociklas1 = new Motociklas("Vespa", 3.2);
            Motociklas motociklas2 = new Motociklas("Yamaha", 4);

            visasTransportas.Add(automobilis1);
            visasTransportas.Add(automobilis2);
            visasTransportas.Add(motociklas1);
            visasTransportas.Add(motociklas2);
            Console.WriteLine("Irasykite nuvaziuota atstuma: ");
            int atstumas = int.Parse(Console.ReadLine());
            
            foreach (TransportoPriemone t in visasTransportas)
            {
                Console.WriteLine($"Transporto priemone {t.Pavadinimas} sunaudotas kuras: {t.ApskaiciuotiKuroSanaudas(atstumas)} litru.");
            }
        }
    }
}
