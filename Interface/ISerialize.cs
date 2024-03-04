﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Interface
{
    internal interface ISerialize
    {
       string SerializeCSV<T>(T fClas);
       string SerializeNewtonsoftJson<T>(T fClas);
    }
}
