using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeans
{
    internal class Seans
    {

        public Film Film { get; set; }
        public Salon Salon { get; set; }
        public string Tarih { get; set; }

        public Seans(Film film, Salon salon, string tarih)
        {
            Film = film;
            Salon = salon;
            Tarih = tarih;
        }

        public string getSeansString()
        {
            return Film.FilmAdi + " - " + Salon.SalonAdi + " - " + Film.SeansSaati + " - " + Tarih;
        }

    }
}
