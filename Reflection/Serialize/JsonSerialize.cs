using Newtonsoft.Json;
using otus_Reflection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Reflection.Serialize
{
    internal class JsonSerialize: ISerializer
    {
        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
