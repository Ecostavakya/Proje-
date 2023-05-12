using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeans
{
    internal class Film
    {
        private string filmAdi { get; set; }
        private string seansSaati { get; set; }

        public Film(string Ad,string Saat)
        {
            FilmAdi = Ad;
            SeansSaati = Saat;
        }

        public string FilmAdi
        {
            get { return filmAdi; }
            set { filmAdi = value; }
        }
        public string SeansSaati
        {
            get { return seansSaati; }
            set { seansSaati = value; }
        }

    }
}
