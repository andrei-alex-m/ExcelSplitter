using CS.BusinessLayer.Dictionaries;
using CS.BusinessLayer.Interfaces;
using System;

namespace CS.BusinessLayer.Model
{
    public class ActProprietate:Act
    {
        public TipActProprietate? Tip { get; set; }
        public string Cota { get; set; }
    }
}