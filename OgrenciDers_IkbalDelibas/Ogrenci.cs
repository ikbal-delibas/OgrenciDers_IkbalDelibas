using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciDers_IkbalDelibas
{
    class Ogrenci
    {
        
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public string Numara { get; set; }
        public int Sinif { get; set; }
        public SinglyLinkedList<Ders> Dersler { get; set; }

        
        public Ogrenci(string Isim, string SoyIsim, string Numara, int Sinif)
        {
            this.Isim = Isim;
            this.SoyIsim = SoyIsim;
            this.Numara = Numara;
            this.Sinif = Sinif;

            this.Dersler = new SinglyLinkedList<Ders>();
        }
        
    }
}
