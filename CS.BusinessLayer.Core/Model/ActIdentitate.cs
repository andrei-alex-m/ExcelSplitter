﻿using CS.BusinessLayer.Dictionaries;
using CS.BusinessLayer.Interfaces;
using System;

namespace CS.BusinessLayer.Model
{
    public class ActIdentitate:Act
    {
        string Serie { get; set; }
        TipActIdentitate? TipActIdentitate { get; set; }
    }
}