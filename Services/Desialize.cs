using Newtonsoft.Json;
using otus_Reflection.Interface;
using otus_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Services
{
    internal class DeSerialize : IDeSerialize
    {
        public F DeSerializeCSV(string str)
        {
            F _f = new F();

            var fields = _f.GetType().GetFields();

            var _dataArrays = str.Split("\r\n");
            var _headers = _dataArrays[0].Split(",").ToList();
            var _values  = _dataArrays[1].Split(",");

            foreach (var field in fields)
            {
                var i = _headers.IndexOf(field.Name);
                var val = Convert.ToInt32(_values[i]);
                field.SetValue(_f, val);
            }
            
            return _f;
        }

        public F DeSerializeNewtonsoftJson(string str)
        {
            return JsonConvert.DeserializeObject<F>(str);
        }
    }
}
