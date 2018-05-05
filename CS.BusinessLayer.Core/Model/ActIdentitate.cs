using CS.BusinessLayer.Dictionaries;
using CS.BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Model
{
    class ActIdentitate : BaseObject, IAct, IActIdentitate
    {
        DateTime? IAct.DataEmiterii { get ; set; }
        string IAct.Emitent { get; set ; }
        int? IAct.Numar { get ; set ; }
        string IActIdentitate.Serie { get ; set ; }
        TipActIdentitate? IActIdentitate.TipActIdentitate { get; set; }
    }
}
