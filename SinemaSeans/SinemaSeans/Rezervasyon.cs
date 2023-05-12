using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeans
{
    internal class Rezervasyon
    {
        public Seans Seans { get; set; }
        public string MusteriAdSoyad { get; set; }
        public int BiletAdedi { get; set; }
        public string[] Koltuklar { get; set; }

        public Rezervasyon(Seans seans, string musteriAdSoyad, int biletAdedi, string[] koltuklar)
        {
            Seans = seans;
            MusteriAdSoyad = musteriAdSoyad;
            BiletAdedi = biletAdedi;
            Koltuklar = koltuklar;
        }

        //public string WriteTiket()
        //{
            
        //}
        public override string ToString()
        {
            string koltukStr = "";
            for (int i = 0; i < Koltuklar.Length; i++)
            {
                if (Koltuklar[i] != "" && Koltuklar[i] != null)
                {
                    if (i > 0)
                        koltukStr += ", ";
                    koltukStr += Koltuklar[i];
                }
                    
            }
            return "\n" + "\n"+"Bilet" + "\n"
                + "Film Adı: " + Seans.Film.FilmAdi + "\n"
                + "Film Süresi: " + Seans.Film.SeansSaati + " dk \n"
                + "Müşteri Ad Soyad: " + MusteriAdSoyad + "\n"
                + "Salon: " +Seans.Salon.SalonAdi + "\n"
                + "Bilet adet: " + BiletAdedi.ToString() + "\n"
                + "Koltuklar: " + koltukStr;
        }
    }
}
