﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Mercedes : Car, IAc
    {
        public string Ac()
        {
            return "AC On...MB";
        }
    }
}
