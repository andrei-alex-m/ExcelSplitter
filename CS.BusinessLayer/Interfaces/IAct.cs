using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    interface IAct
    {
        DateTime? DataEmiterii { get; set; }
        string Emitent { get; set; }
        int? Numar { get; set; }

    }
}
