using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatParking.Model
{
    public class Lokacija
    {
        double xKordinata { get; set; }
        double yKordinata { get; set; }
        string adresa { get; set; }

        public Lokacija(double x, double y, string ad)
        {
            xKordinata = x;
            yKordinata = y;
            adresa = ad;
        }

        public double dajX() { return xKordinata; }
        public double dajY() { return yKordinata; }
        public string dajAdresu() { return adresa; }

        public void postaviX(double x) { xKordinata = x; }
        public void postaviY(double y) { xKordinata = y; }
        public void postaviAdresu(string adresaa) { adresa = adresaa; }
    }
}
