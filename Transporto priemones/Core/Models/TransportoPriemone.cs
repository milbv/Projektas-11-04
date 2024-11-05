using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporto_priemones.Core.Models
{
    public class TransportoPriemone
    {
        public string Pavadinimas { get; set; }
        public double KuroSanaudos100km { get; set; }

        public TransportoPriemone(double kuroSanaudos100km)
        {
            KuroSanaudos100km = kuroSanaudos100km;
        }
        public TransportoPriemone(string pavadinimas, double kuroSanaudos100km)
        {
            Pavadinimas = pavadinimas;
            KuroSanaudos100km = kuroSanaudos100km;
        }
        public TransportoPriemone()
        {
        }

        public double ApskaiciuotiKuroSanaudas(int kelias)
        {
            return (KuroSanaudos100km * kelias) / 100;
        }
    }
}
