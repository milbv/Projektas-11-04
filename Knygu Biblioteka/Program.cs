using Knygu_Biblioteka.Core.FileRepository;
using Knygu_Biblioteka.Core.Models;
using System;

namespace Knygu_Biblioteka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileRepository fr = new FileRepository("knygos.txt");
            List<Knyga> visosKnygos = fr.VisosKnygos();
            bool running = false;
            while (!running)
            {
                Console.WriteLine("\r\n1. Peržiūrėti visas knygas.\r\n2. Filtruoti knygas pagal žanrą.\r\n3. Rikiuoti knygas pagal išleidimo metus.\r\n4. Ieškoti knygos pagal autorių ar pavadinimą.\r\n5. Pridėti naują knygą.\r\n6. Išsaugoti visų knygų informaciją į failą.");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        foreach (Knyga k in visosKnygos)
                        {
                            k.SpausdintiInformacija();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Irasykite zanra, pagal kuri norite rasti knygas:");
                        string ieskomaszanras = Console.ReadLine();
                        List<Knyga> zanroKnygos = ZanroFiltras(visosKnygos, ieskomaszanras);
                        if (zanroKnygos != null) 
                        { 
                            foreach (Knyga k in zanroKnygos)
                            {
                            k.SpausdintiInformacija();
                            }
                        } else
                        {
                            Console.WriteLine("Siuo metu sio zanro knygu neturime");
                        }
                        break;
                    case 3:
                        SortByDate(visosKnygos);
                        break;
                    case 4:
                        Console.WriteLine("Iveskite autoriaus varda arba knygos pavadinima:");
                        string call = Console.ReadLine();
                        List<Knyga> ieskomosKnygos = KnygosPaieska(visosKnygos, call);
                        if (ieskomosKnygos != null)
                        {
                            foreach (Knyga k in ieskomosKnygos)
                            {
                                k.SpausdintiInformacija();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sio autoriaus knygu arba sios knygos siuo metu neturime");
                        }
                        break;
                    case 5:
                        int id = visosKnygos.Count() + 1;
                        string pavadinimas = "";
                        string autorius = "";
                        int isleidimoMetai;
                        string zanras = "";
                        Console.WriteLine("Iveskite knygos pavadinima");
                        pavadinimas = Console.ReadLine();
                        Console.WriteLine("Iveskite autoriu");
                        autorius = Console.ReadLine();
                        Console.WriteLine("Iveskite knygos isleidimo metus");
                        isleidimoMetai = int.Parse(Console.ReadLine());
                        Console.WriteLine("Iveskite knygos zanra");
                        zanras = Console.ReadLine();
                        Console.WriteLine("Ar si knyga yra elektronine?");
                        if (Console.ReadLine() == "taip")
                        {
                            Console.WriteLine("Kiek vietos uzima si knyga Mb?");
                            double mb = double.Parse(Console.ReadLine());
                            Console.WriteLine("Kokio formato yra knyga?");
                            string formatas = Console.ReadLine();
                            visosKnygos.Add(new ElektronineKnyga(id, pavadinimas, autorius, isleidimoMetai, zanras, mb, formatas));
                        } else
                        {
                            Console.WriteLine("Kiek puslapiu yra sioje knygoje?");
                            int puslapiai = int.Parse(Console.ReadLine());
                            visosKnygos.Add(new PopierineKnyga(id, pavadinimas, autorius, isleidimoMetai, zanras, puslapiai));
                        }
                        break;
                    case 6:
                        fr.RasytiKnygasIBiblioteka(visosKnygos);
                        break;
                    default:
                        running = true;
                        break;
                }
            }
        }
        public static List<Knyga> ZanroFiltras(List<Knyga> visosKnygos, string zanras)
        {
            return visosKnygos.FindAll((k) => k.Zanras.ToLower() == zanras.ToLower()).ToList();
        }
        public static void SortByDate(List<Knyga> visosKnygos)
        {
            visosKnygos.Sort((a, b) => a.IsleidimoMetai - b.IsleidimoMetai);
        }
        public static List<Knyga> KnygosPaieska(List<Knyga> visosKnygos, string call)
        {
            return visosKnygos.FindAll((k) =>(k.Autorius.ToLower() == call.ToLower()) || (k.Pavadinimas.ToLower() == call.ToLower())).ToList();
        }

    }
}
