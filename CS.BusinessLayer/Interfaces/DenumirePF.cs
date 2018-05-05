using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    class DenumirePF : IDenumire
    {
        public string Nume { get ; set ; }
        public string Initiala { get; set; }
        public string Prenume { get; set; }
    }
}
