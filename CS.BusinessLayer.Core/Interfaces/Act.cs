using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    public abstract class Act
    {
        DateTime? DataEmiterii { get; set; }
        string Emitent { get; set; }
        int? Numar { get; set; }

    }
}
