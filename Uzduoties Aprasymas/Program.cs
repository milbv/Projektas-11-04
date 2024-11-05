using Uzduoties_Aprasymas.Core;
using Uzduoties_Aprasymas.Core.Models;

namespace Uzduoties_Aprasymas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileRepository fr = new FileRepository("darbuotojai.txt");
            List<Darbuotojas> visiDarbuotojai = fr.VisiDarbuotojai();
            foreach(Darbuotojas d in visiDarbuotojai)
            {
                d.SpausdintiInformacija();
            }
        }
    }
}
