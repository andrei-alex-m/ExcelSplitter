using CS.BusinessLayer.Dictionaries;
using CS.BusinessLayer.Interfaces;
using System;

namespace CS.BusinessLayer.Model
{
    public class Parcela
    {
        public int IdTarla { get; set; }
        public string Tarla {get;}
        public string Numar {get; set;}
        public CatFol? CatFol { get; set; }
        public double Suprafata {get;set;}
    }
}
