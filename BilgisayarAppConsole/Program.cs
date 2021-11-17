using BilgisayarAppConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarAppConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Marka: ");
            string marka = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Hız (GHz): ");
            double ghz = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hafıza (GB): ");
            short ram = Convert.ToInt16(Console.ReadLine());
            Console.Write("Ekran boyutu (inç): ");
            double ekranBoyutu = Convert.ToDouble(Console.ReadLine());
            Console.Write("Su soğutmalı (e: evet, h: hayır): ");
            string suSogutmaliMiGiris = Console.ReadLine();
            bool suSogutmaliMi;
            if (suSogutmaliMiGiris == "e")
                suSogutmaliMi = true;
            else
                suSogutmaliMi = false;
            Console.Write("Üretim tarihi: (gg.aa.yyyy) ");
            DateTime uretimTarihi = DateTime.Parse(Console.ReadLine());
            Console.Write("Bilgisayar tipi: (s: server, m: masaüstü, d: dizüstü)");
            string bilgisayarTipiGiris = Console.ReadLine();
            BilgisayarTipi tipi;
            switch (bilgisayarTipiGiris)
            {
                case "s":
                    tipi = BilgisayarTipi.Server;
                    break;
                case "m":
                    tipi = BilgisayarTipi.Masaüstü;
                    break;
                default:
                    tipi = BilgisayarTipi.Dizüstü;
                    break;
            }

            Bilgisayar bilgisayar1 = new Bilgisayar()
            {
                EkranBoyutu = ekranBoyutu,
                GHz = ghz,
                Id = 1,
                Marka = marka,
                Model = model,
                RAM = ram,
                SuSogutmaliMi =suSogutmaliMi,
                Tipi = tipi,
                UretimTarihi = uretimTarihi
            };

            Console.WriteLine($"Marka: {bilgisayar1.Marka}");
            Console.WriteLine($"Model: {bilgisayar1.Model}");
            Console.WriteLine($"Ekran boyutu: {bilgisayar1.EkranBoyutu}");
            Console.WriteLine($"GHz: {bilgisayar1.GHz}");
            Console.WriteLine($"RAM: {bilgisayar1.RAM}");
            Console.WriteLine($"Su Soğutma: {bilgisayar1.SuSogutmaliMi}");
            Console.WriteLine($"Tipi: {bilgisayar1.Tipi}");
            Console.WriteLine($"Üretim Tarihi: {bilgisayar1.UretimTarihi}");
            Console.WriteLine($"Id: {bilgisayar1.Id}");

            Console.ReadLine();

        }
    }

}
