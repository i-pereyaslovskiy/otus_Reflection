using Newtonsoft.Json;
using otus_Reflection.Interface;
using otus_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Reflection.Deserialize
{
    internal class JsonDeserialize : IDeserializer
    {
        public T Deserialize<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
