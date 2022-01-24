using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciDers_IkbalDelibas
{
    class Program
    {
        public static SinglyLinkedList<Ders> dersListesi;
        public static SinglyLinkedList<Ogrenci> OgrenciListesi;
        static void Main(string[] args)
        {
            dersListesi = new SinglyLinkedList<Ders>();
            OgrenciListesi = new SinglyLinkedList<Ogrenci>();
            OgrenciDers();
            Dosyalamak();
            // dosyamı OgrenciDers_IkbalDelibas\OgrenciDers_IkbalDelibas\bin\Debug\netcoreapp3.1 adresinde oluşturdum. konsolda da dosyam gözükmektedir.



        }
        public static void OgrenciDers()
        {
            Ders ders1 = new Ders("BIL3101", "Ayhan İstanbullu", 5, "Bilgisayar Organizasyonu");
            Ders ders2 = new Ders("BIL3103","Suat Onur", 5,  "Bilgisayar Ağları");
            Ders ders3 = new Ders("BIL3107", "Selçuk Kavut", 5,"Biçimsel Diller ve Otomatlar" );
            Ders ders4 = new Ders("BIL3109","Hüseyin Güneş" , 5,"Veritabanı Yönetim Sistemleri" );
            Ders ders5 = new Ders("ISG3101", "Metin  Demirtaş", 5,"İş Sağlığı ve Güvenliği I" );

            Ders ders6 = new Ders("AIT1101", "ŞENER TEKER", 2,"Atatürk İlkeleri ve İnkılap Tarihi-I" );
            Ders ders7 = new Ders("BIL1103","GÜLTEKİN KUVAT" , 5, "Programlama I");
            Ders ders8 = new Ders("BIL1105", "DİLEK DİLSİZOĞLU", 5,"Lineer Cebir" );
            Ders ders9 = new Ders("BIL1107", "FATİH AYDIN", 3,"Bilgisayar Mühendisliğine Giriş" );
            Ders ders10 = new Ders("BIL1109", "GÜLTEKİN KUVAT", 1,"Programlama Lab I" );
            Ders ders11 = new Ders("FIZ1101","ERSEN METE", 4,  "Fizik I");
            Ders ders12 = new Ders("FIZ1102", " LEVENT SOLMAZ", 5, "Fizik I Laboratuvar");
            Ders ders13 = new Ders("MAT1101", "RECEP ŞAHİN", 5,"Matematik I" );
            Ders ders14 = new Ders("TDI1101","GÜLFİYE BULUT" , 2, "Türk Dili I");
            Ders ders15 = new Ders("YDI1101", "TEMEL SERDAR YILMAZ", 2, "Yabancı Dil I (İngilizce)");

            Ders ders16 = new Ders("BIL2101", "GÜLSÜM GEZER", 5, "Diferansiyel Denklemler");
            Ders ders17 = new Ders("BIL2103","AYHAN İSTANBULLU" , 5, "Elektronik Devreler");
            Ders ders18 = new Ders("BIL2105","AYHAN İSTANBULLU" , 2,"Elektronik Devreler Lab." );
            Ders ders19 = new Ders("BIL2107","FATİH AYDIN", 5,  "Veri Yapıları ve Algoritmalar");
            Ders ders20 = new Ders("BIL2109","FATİH AYDIN", 5, "Nesneye Yönelik Programlama" );
            Ders ders21 = new Ders("SECSOS3YY", "---" , 3,"Sosyal Seçmeli I");
            Ders ders22 = new Ders("SECTEK3YY",  "---", 3,"Teknik Seçmeli I");

            Ders ders23 = new Ders("BIL4101","---" , 5,"Bilgisayar Mühendisliği Tasarımı" );
            Ders ders24 = new Ders("BMU4101", "---", 30,"İşyeri Eğitimi" );
            Ders ders25 = new Ders("SECMES7YY", "---", 25,"Mesleki Seçmeli (7. Dönem)" );

            dersListesi.Add(ders1);
            dersListesi.Add(ders2);
            dersListesi.Add(ders3);
            dersListesi.Add(ders4);
            dersListesi.Add(ders5);
            dersListesi.Add(ders6);
            dersListesi.Add(ders7);
            dersListesi.Add(ders8);
            dersListesi.Add(ders9);
            dersListesi.Add(ders10);
            dersListesi.Add(ders11);
            dersListesi.Add(ders12);
            dersListesi.Add(ders13);
            dersListesi.Add(ders14);
            dersListesi.Add(ders15);
            dersListesi.Add(ders16);
            dersListesi.Add(ders17);
            dersListesi.Add(ders18);
            dersListesi.Add(ders19);
            dersListesi.Add(ders20);
            dersListesi.Add(ders21);
            dersListesi.Add(ders22);
            dersListesi.Add(ders23);
            dersListesi.Add(ders24);
            dersListesi.Add(ders25);

            Ogrenci ogrenci1 = new Ogrenci("İkbal", "Delibaş", "201913709035", 3);
            Ogrenci ogrenci2 = new Ogrenci("Ayşeur", "Gülsüm", "202113709004", 1);
            Ogrenci ogrenci3 = new Ogrenci("Alperen", "Karslı", "202013709053", 2);
            Ogrenci ogrenci4 = new Ogrenci("Mervenur", "Ayvaz", "201813709003", 4);

            ogrenci1.Dersler.Add(ders1);
            ogrenci1.Dersler.Add(ders2);
            ogrenci1.Dersler.Add(ders3);
            ogrenci1.Dersler.Add(ders4);
            ogrenci1.Dersler.Add(ders5);

            ogrenci2.Dersler.Add(ders6);
            ogrenci2.Dersler.Add(ders7);
            ogrenci2.Dersler.Add(ders8);
            ogrenci2.Dersler.Add(ders9);
            ogrenci2.Dersler.Add(ders10);
            ogrenci2.Dersler.Add(ders11);
            ogrenci2.Dersler.Add(ders12);
            ogrenci2.Dersler.Add(ders13);
            ogrenci2.Dersler.Add(ders14);
            ogrenci2.Dersler.Add(ders15);

            ogrenci3.Dersler.Add(ders16);
            ogrenci3.Dersler.Add(ders17);
            ogrenci3.Dersler.Add(ders18);
            ogrenci3.Dersler.Add(ders19);
            ogrenci3.Dersler.Add(ders20);
            ogrenci3.Dersler.Add(ders21);
            ogrenci3.Dersler.Add(ders22);

            ogrenci4.Dersler.Add(ders23);
            ogrenci4.Dersler.Add(ders24);
            ogrenci4.Dersler.Add(ders25);

            OgrenciListesi.Add(ogrenci1);
            OgrenciListesi.Add(ogrenci2);
            OgrenciListesi.Add(ogrenci3);
            OgrenciListesi.Add(ogrenci4);

            Console.WriteLine("Öğrenciler ve aldıkları dersler:\n\n");
            IEnumerable<Ogrenci> e = OgrenciListesi.GetEnumerator();
            foreach (Ogrenci b in e)
            {
                Console.WriteLine(b.Isim + " " + b.SoyIsim+" Sınıf: "+b.Sinif+"\n");

                IEnumerable<Ders> e2 = b.Dersler.GetEnumerator();
                
                foreach (Ders d in e2)
                {
                    Console.WriteLine(d.DersKodu + " " + d.DersAdı + " " + d.Kredi);
                }
                Console.WriteLine("-------------------------------");
            }



            
           
        }
        
        public static void Dosyalamak()
        {
            string json = "{\n";
            string jsonders;
            string jsonogrenci;
            using (StreamWriter wr = new StreamWriter("OgrenciDers.txt"))
            {
                IEnumerable<Ders> y = dersListesi.GetEnumerator();
                json = json + "\"dersler\":[\n";
                foreach (Ders d in y)
                {
                    jsonders = "  {\n";
                    jsonders = jsonders + "   \"DersKodu\":" + "\"" + d.DersKodu + "\",\n";
                    jsonders = jsonders + "   \"DersAdı\":" + "\"" + d.DersAdı + "\",\n";
                    jsonders = jsonders + "   \"Ogretmen\":" + "\"" + d.Ogretmen + "\",\n";
                    jsonders = jsonders + "   \"Kredi\":" + d.Kredi + "\n";

                    jsonders = jsonders + "  },\n";
                    json = json + jsonders;
                }

                json = json.Remove(json.LastIndexOf(","), 1);
                json = json + "],\n";



                IEnumerable<Ogrenci> e2 = OgrenciListesi.GetEnumerator();
                json = json + "\"bolumler\":[\n";
                foreach (Ogrenci b in e2)
                {
                    jsonogrenci = "  {\n";
                    jsonogrenci = jsonogrenci + "   \"Isim\":" + "\"" + b.Isim + "\",\n";
                    jsonogrenci = jsonogrenci + "   \"Soyisim\":" + "\"" + b.SoyIsim + "\",\n";
                    jsonogrenci = jsonogrenci + "   \"Numara\":" + "\"" + b.Numara + "\",\n";
                    jsonogrenci = jsonogrenci + "   \"Sinif\":" + "\"" + b.Sinif + "\",\n";


                    jsonogrenci = jsonogrenci + "   \"dersler\":[\n";

                    IEnumerable<Ders> e3 = b.Dersler.GetEnumerator();
                    foreach (Ders d in e3)
                    {
                        jsonders = "      {\n";
                        jsonders = jsonders + "       \"DersKodu\":" + "\"" + d.DersKodu + "\",\n";
                        jsonders = jsonders + "       \"DersAdı\":" + "\"" + d.DersAdı + "\",\n";
                        jsonders = jsonders + "       \"Kredi\":" + d.Kredi + "\n";
                        jsonders = jsonders + "   \"Ogretmen\":" + "\"" + d.Ogretmen + "\",\n";

                        jsonders = jsonders + "      },\n";
                        jsonogrenci = jsonogrenci + jsonders;
                    }
                    if (b.Dersler.Count > 0)
                    {
                        jsonogrenci = jsonogrenci.Remove(jsonogrenci.LastIndexOf(","), 1);
                    }


                    jsonogrenci = jsonogrenci + "    ]\n";

                    jsonogrenci = jsonogrenci + "  },\n";

                    json = json + jsonogrenci;


                }
                json = json.Remove(json.LastIndexOf(","), 1);
                json = json + "\n]\n";

                json = json + "}";

                Console.WriteLine(json);
                wr.WriteLine(json);
            }
        }
    }
}
