using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Interface
{
    internal interface ISerializer
    {
       public string Serialize<T>(T obj);
    }
}
