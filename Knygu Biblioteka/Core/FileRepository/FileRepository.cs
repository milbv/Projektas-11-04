using Knygu_Biblioteka.Core.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knygu_Biblioteka.Core.FileRepository
{
    public class FileRepository
    {
        private string _fileLocation { get; set; }
        
        public FileRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
        }
        public List<Knyga> VisosKnygos()
        {
            List<Knyga> knygos = new List<Knyga>();
            using (StreamReader sr = new StreamReader(_fileLocation))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (string.IsNullOrEmpty(line))
                    {
                        break;
                    }
                    string[] foo = line.Split(";");
                    if (foo[5] == "PopierineKnyga")
                    {
                        knygos.Add(new PopierineKnyga(int.Parse(foo[0]), foo[1], foo[2], int.Parse(foo[3]), foo[4], int.Parse(foo[6])));
                    }
                    else if (foo[5] == "ElektronineKnyga")
                    {
                        knygos.Add(new ElektronineKnyga(int.Parse(foo[0]), foo[1], foo[2], int.Parse(foo[3]), foo[4], double.Parse(foo[6], CultureInfo.InvariantCulture), foo[7]));
                    }
                }
                return knygos;
            }

        }
        public void RasytiKnygasIBiblioteka(List<Knyga> knygos)
        {
            using (StreamWriter sw = new StreamWriter(_fileLocation))
            {
                foreach (Knyga k in knygos)
                {
                    if (k is ElektronineKnyga)
                    {
                        sw.WriteLine($"{k.ID};{k.Pavadinimas};{k.Autorius};{k.IsleidimoMetai};{k.Zanras};{((ElektronineKnyga)k).FailoDydis}; {((ElektronineKnyga)k).Formatas}");
                    }
                    else if (k is PopierineKnyga)
                    {
                        sw.WriteLine($"{k.ID};{k.Pavadinimas};{k.Autorius};{k.IsleidimoMetai};{k.Zanras};{((PopierineKnyga)k).PuslapiuSkaicius}");
                    }
                    else
                    {
                        sw.WriteLine($"{k.ID};{k.Pavadinimas};{k.Autorius};{k.IsleidimoMetai};{k.Zanras}");
                    }
                }
                sw.Close();
            }
        }

    }
}
