using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    class IdentificatorPJ:Identificator
    {
        public int CUI { get; set; }
        public bool RO { get; set; }
    }
}
