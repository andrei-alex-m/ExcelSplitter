using CS.BusinessLayer.Dictionaries;
using System;

namespace CS.BusinessLayer.Interfaces
{
    interface IActIdentitate
    {
        string Serie { get; set; }
        TipActIdentitate? TipActIdentitate { get; set; }
    }
}