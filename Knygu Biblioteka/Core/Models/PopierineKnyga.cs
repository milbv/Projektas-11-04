using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knygu_Biblioteka.Core.Models
{
    public class PopierineKnyga : Knyga
    {
        public int PuslapiuSkaicius { get; set; }

        public PopierineKnyga(int id, string pavadinimas, string autorius, int isleidimoMetai, string zanras, int puslapiuSkaicius)
            : base (id, pavadinimas, autorius, isleidimoMetai, zanras)
        {
            PuslapiuSkaicius = puslapiuSkaicius;
        }
        public override void SpausdintiInformacija()
        {
            Console.WriteLine($"{ID}; {Pavadinimas}; {Autorius}; {IsleidimoMetai}; {Zanras}; {PuslapiuSkaicius}");
        }
    }
}
