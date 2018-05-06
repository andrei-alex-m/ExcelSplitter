using CS.BusinessLayer.Dictionaries;
using CS.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    abstract class Persoana
    {
        public Denumire Denumire { get; set; }
        public Identificator Identificator { get; set; }
        public Adresa Adresa { get; set; }
        public TipPersoana Tip { get; set; }
    }
}
