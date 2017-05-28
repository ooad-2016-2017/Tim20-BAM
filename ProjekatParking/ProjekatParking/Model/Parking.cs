using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace ProjekatParking.Model
{
    class Parking
    {
        static int id = 1;
        string naziv { get; set; }
        Lokacija lokacija;
        int kapacitet;
        int brojSlobodnihMjesta;
        string tipParkinga { get; set; }
        Image slikaParkinga { get; set; }
        double cijenaPoSatu;
        DateTime vrijemeOtvaranja { get; set; }
        DateTime vrijemeZatvaranja { get; set; }

        Parking(string naziva, Lokacija lokacijaa, int kapaciteta, int brojSlobodnihMjestaa, string tipParkingaa, Image slikaParkingaa, double cijenaPoSatua, DateTime vrijemeOtvaranjaa, DateTime vrijemeZatvaranjaa)
        {
            Id = id++;
            lokacija = lokacijaa;
            naziv = naziva;
            Kapacitet = kapaciteta;
            brojSlobodnihMjesta = brojSlobodnihMjestaa;
            tipParkinga = tipParkingaa;
            slikaParkinga = slikaParkingaa;
            cijenaPoSatu = cijenaPoSatua;
            vrijemeOtvaranja = vrijemeOtvaranjaa;
            vrijemeZatvaranja = vrijemeZatvaranjaa;
        }

        public static int Id
        {
            get { return id; }
            set { Id = id; }
        }

        public int Kapacitet
        {
            get { return kapacitet; }
            set
            {
                if (kapacitet < 1) throw new Exception("Neispravan unos kapaciteta");
                Kapacitet = kapacitet;
            }
        }

        public int BrojSlobodnihMjesta
        {
            get { return brojSlobodnihMjesta; }
            set
            {
                if (brojSlobodnihMjesta > Kapacitet) throw new Exception("Neispravan unos slobodnih mjesta");
                BrojSlobodnihMjesta = brojSlobodnihMjesta;
            }
        }

        public double CijenaPoSatu
        {
            get { return cijenaPoSatu; }
            set
            {
                if (cijenaPoSatu < 0) throw new Exception("Neispravan unos cijene parkinga po satu");
                CijenaPoSatu = cijenaPoSatu;
            }
        }

        int dajBrojSlobodnihMjesta() { return BrojSlobodnihMjesta; }

        string dajTipParkinga() { return tipParkinga; }

        Image dajSlikuParkinga() { return slikaParkinga; }

        double dajCijenuPoSatu() { return CijenaPoSatu; }

        DateTime dajVrijemeOtvaranja() { return vrijemeOtvaranja; }

        DateTime dajVrijemeZatvaranja() { return vrijemeZatvaranja; }

        public string dajNaziv() { return naziv; }

        Lokacija dajLokaciju() { return lokacija; }

        int dajKapacitet() { return Kapacitet; }

    }
}
