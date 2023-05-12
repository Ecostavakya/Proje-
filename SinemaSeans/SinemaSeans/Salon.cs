using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaSeans
{
    internal class Salon
    {
        private string salonAdi { get; set; }
        private int salonKapasitesi { get; set; }

        public Salon(string Ad, int Kapasitesi)
        {
            SalonAdi = Ad;
            SalonKapasitesi = Kapasitesi;
        }

        public string SalonAdi
        {
            get { return salonAdi; }
            set { salonAdi = value; }
        }
        public int SalonKapasitesi
        {
            get { return salonKapasitesi; }
            set { salonKapasitesi -= value; }
        }

    }
}
