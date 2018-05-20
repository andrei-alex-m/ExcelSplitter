using Caly.Utils;
using CS.BusinessLayer.Dictionaries;
using CS.BusinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Model
{
/*     abstract class Persoana
    {
        public Denumire Denumire { get; set; }
        public Identificator Identificator { get; set; }
        public Adresa Adresa { get; set; }
        public TipPersoana Tip { get; set; }
    } */

     public class Persoana : BaseObject
    {
        string Nume { get; set; }
        public string Initiala { get; set; }
        public string Prenume { get; set; }
        public int? IdActIdentitate { get; set; }
        public ActIdentitate ActIdentitate { get; set; }
        public string Identificator { get; set; }        
        public int? IdAdresa { get; set; }
        public Adresa Adresa { get; set; }

    }
}
