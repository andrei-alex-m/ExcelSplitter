using CS.BusinessLayer.Dictionaries;
using CS.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Model
{


    class PersoanaFizica:BaseObject, IPersoana
    {
        public String Nume { get; set; }
        public String Initiala { get; set; }
        public String Prenume { get; set; }
        public String Tip { get; set; }
        public String CNP { get; set; }
        public int? IDAdresa { get; set; }
        public int? IDActIdentitate { get; set; }
        public Adresa Adresa { get; set; }
        public ActIdentitate ActIdentitate { get; set; }
        public DenumirePF Denumire { get ; set ; }
        public IIdentificator Identificator { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        IAdresa IPersoana.Adresa { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        TipPersoana IPersoana.Tip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
