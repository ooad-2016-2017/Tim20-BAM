using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatParking.Model
{
    class Admin
    {
        string username { get; set; }
        string password { get; set; }
        List<Parking> listaParkinga { get; set; }

        public Admin(string user, string pass)
        {
            username = user;
            password = pass;
            listaParkinga = new List<Parking>();
        }

        void registrujParking(Parking p) { listaParkinga.Add(p); }
        void odjaviParking(string naziv)
        {
            foreach (Parking p in listaParkinga)
            {
                if (p.dajNaziv().Equals(naziv))
                    listaParkinga.Remove(p);
            }
        }
    }
}
