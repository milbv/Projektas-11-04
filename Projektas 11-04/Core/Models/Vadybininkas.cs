using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_11_04.Core.Models
{
    public class Vadybininkas : Darbuotojas
    {
        public Vadybininkas(string vardas, long asmensKodas, double bazinisAtlyginimas)
        : base(vardas, asmensKodas, bazinisAtlyginimas)
        {
        }
        public Vadybininkas(string vardas, string pavarde, long asmensKodas, double bazinisAtlyginimas)
        : base(vardas, pavarde, asmensKodas, bazinisAtlyginimas)
        {
        }
    }
}
