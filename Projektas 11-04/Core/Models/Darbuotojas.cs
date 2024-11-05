using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_11_04.Core.Models
{
    public class Darbuotojas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; } = "";
        public long AsmensKodas { get; set; }
        public double BazinisAtlyginimas { get; set; }

        public Darbuotojas(string vardas, string pavarde, long asmensKodas, double bazinisAtlyginimas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            AsmensKodas = asmensKodas;
            BazinisAtlyginimas = bazinisAtlyginimas;
        }
        public Darbuotojas(string vardas, long asmensKodas, double bazinisAtlyginimas)
        {
            Vardas = vardas;
            AsmensKodas = asmensKodas;
            BazinisAtlyginimas = bazinisAtlyginimas;
        }
        public Darbuotojas()
        {
        }
    }
}
