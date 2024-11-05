using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduoties_Aprasymas.Core.Models
{
    public class Inzinierius : Darbuotojas
    {
        public string Specializacija { get; set; }
        
        public Inzinierius(int id, string vardas, string pavarde, double atlyginimas, string specializacija)
            :base(id, vardas, pavarde, atlyginimas)
        {
            Specializacija = specializacija;
        }
    }
}
