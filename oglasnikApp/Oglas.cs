using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OglasnikApp
{
    public class Oglas
    {
        //ctor
        public Oglas(string naslov, string opis) {
            Naslov = naslov;
            Opis = opis;
        }

        //bez ovog ce biti potpuni kaos u Oglasi boxu
        public override string ToString()
        {
            return Naslov + " " + Opis;
        }

        //prop
        public string Naslov { get; set; }
        public string Opis { get; set; }
    }
}
