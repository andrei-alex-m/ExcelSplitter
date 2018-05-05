using CS.BusinessLayer.Dictionaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    interface IPersoana
    {
         IDenumire Denumire { get; set; }
        IIdentificator Identificator { get; set; }
        IAdresa Adresa { get; set; }
        TipPersoana Tip { get; set; }
    }
}
