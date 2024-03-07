using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otus_Reflection.Models;

namespace otus_Reflection.Interface
{
    internal interface IDeserializer
    {
        public T Deserialize<T>(string str);
    }
}
