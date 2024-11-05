﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektas_11_04.Core.Models
{
    public class Programuotojas : Darbuotojas
    {
        public Programuotojas(string vardas, long asmensKodas, double bazinisAtlyginimas)
            : base(vardas,asmensKodas, bazinisAtlyginimas)
        {
        }
        public Programuotojas(string vardas, string pavarde, long asmensKodas, double bazinisAtlyginimas)
            : base(vardas, pavarde, asmensKodas, bazinisAtlyginimas)
        { 
        }
        
    }
}
