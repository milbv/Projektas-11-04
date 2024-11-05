using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uzduoties_Aprasymas.Core.Models;

namespace Uzduoties_Aprasymas.Core
{
    public class FileRepository
    {
        private string _fileLocation;
        public FileRepository(string fileLocation)
        {
            _fileLocation = fileLocation;
        }
        
        public List<Darbuotojas> VisiDarbuotojai()
        {
            List<Darbuotojas> darbuotojai = new List<Darbuotojas>();
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
                    if (foo[4] == "Vadybininkas") {
                        darbuotojai.Add(new Vadybininkas(int.Parse(foo[0]), foo[1], foo[2], double.Parse(foo[3]), foo[5]));
                    } else if (foo[4] == "Inzinierius") {
                        darbuotojai.Add(new Inzinierius(int.Parse(foo[0]), foo[1], foo[2], double.Parse(foo[3]), foo[5]));
                    }
                }
                return darbuotojai;
            }
        }
    }
}
