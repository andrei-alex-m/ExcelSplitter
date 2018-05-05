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

    }
}
