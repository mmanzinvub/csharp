using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OglasnikApp
{
    public class Oglasnik
    {
        //ctor
        public Oglasnik()
        {
            //nemoj pisati 'List<Oglas> oglasi = ...' nego samo oglasi (quo)
            oglasi = new List<Oglas>();
        }

        //(Oglas oglas) je tocan nacin, a ne (string naslov, string opis, ...) (quo)
        public void DodajOglas(Oglas oglas)
        {
            oglasi.Add(oglas);
        }

        public List<Oglas> SviOglasi()
        {
            //.ToImmutableList<Oglas>() bi se moglo i trebalo, ali necemo sada (quo)
            return oglasi;
        }

        //lista sa oglasima, private jer jako PRIVATE info
        //ovo je referenca (quo)
        //prop
        private List<Oglas> oglasi;
    }
}
