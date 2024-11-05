using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knygu_Biblioteka.Core.Models
{
    public class ElektronineKnyga : Knyga
    {
        public double FailoDydis { get; set; }
        public string Formatas { get; set; }
        public ElektronineKnyga(int id, string pavadinimas, string autorius, int isleidimoMetai, string zanras, double failoDydis, string formatas)
            : base(id, pavadinimas, autorius, isleidimoMetai, zanras)
        {
            FailoDydis = failoDydis;
            Formatas = formatas;  
        }
        public override void SpausdintiInformacija()
        {
            Console.WriteLine($"{ID}; {Pavadinimas}; {Autorius}; {IsleidimoMetai}; {Zanras}; {FailoDydis}; {Formatas}");
        }
    }
}
