﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.BusinessLayer.Interfaces
{
    class IdentificatorPF:Identificator, IValidator
    {
        public int CNP { get; set; }
        //public static Validator Validator { get {return new Validator(); }
    }
}
