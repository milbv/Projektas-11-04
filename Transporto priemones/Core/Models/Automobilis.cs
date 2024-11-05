using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transporto_priemones.Core.Models
{
    public class Automobilis : TransportoPriemone
    {
        public Automobilis(string pavadinimas, double kuroSanaudos100km)
            : base(pavadinimas, kuroSanaudos100km)
        {

        }
        public Automobilis(double kuroSanaudos100km)
            : base(kuroSanaudos100km)
        {

        }
    }
}
