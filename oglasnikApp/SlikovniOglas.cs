using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OglasnikApp
{
    public class SlikovniOglas : Oglas
    {
        //base je bazni konstruktor (quo)
        //ctor
        public SlikovniOglas(string naslov, string opis, string link) : base(naslov, opis)
        {
            Link = link;
        }

        //prop
        public string Link { get; set; }
    }
}
