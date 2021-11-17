using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgisayarAppConsole.Models
{
    public class Bilgisayar
    {
        public int Id { get; set; }
        public short RAM { get; set; }
        public double GHz { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool SuSogutmaliMi { get; set; }
        public double EkranBoyutu { get; set; }
        public DateTime UretimTarihi { get; set; }
        public BilgisayarTipi Tipi { get; set; }
    }

}
