using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduoties_Aprasymas.Core.Models
{
    public class Darbuotojas
    {
        public int ID { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public double Atlyginimas { get; set; }
        public Darbuotojas(int id, string vardas, string pavarde, double atlyginimas)
        {
            ID = id;
            Vardas = vardas;
            Pavarde = pavarde;
            Atlyginimas = atlyginimas;
        }
        public Darbuotojas()
        {

        }
        public void SpausdintiInformacija()
        {
            Console.WriteLine($"{ID}, {Vardas}, {Pavarde}, {Atlyginimas}, ");
        }
    }
}
