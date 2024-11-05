using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knygu_Biblioteka.Core.Models
{
    public class Knyga
    {
        public int ID { get; set; }
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }
        public int IsleidimoMetai { get; set; }
        public string Zanras { get; set; }
        
        public Knyga(int id, string pavadinimas, string autorius, int isleidimoMetai, string zanras)
        {
            ID = id;
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            IsleidimoMetai = isleidimoMetai;
            Zanras = zanras;
        }
        public Knyga()
        {
        }
        public virtual void SpausdintiInformacija()
        {
            Console.WriteLine($"{ID}; {Pavadinimas}; {Autorius}; {IsleidimoMetai}; {Zanras}");
        }
    }
}
