
using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciDers_IkbalDelibas
{
    class Ders
    {
        public string DersKodu { get; set; }
        public string DersAdı { get; set; }
        public string Ogretmen { get; set; }
        
        public int Kredi { get; set; }
        public Ders(string DersKodu, string Ogretmen, int Kredi, string DersAdı)
        {
            this.DersKodu = DersKodu;
            this.DersAdı = DersAdı;
            this.Kredi = Kredi;
            this.Ogretmen = Ogretmen;
        }
    }
}
