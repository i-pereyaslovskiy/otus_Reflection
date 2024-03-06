using otus_Reflection.Interface;
using otus_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Reflection.Deserialize
{
    internal class CsvDeserializer : IDeserializer
    {
        public F DeSerialize(string str)
        {
            F _f = new F();

            var type = _f.GetType();
            var fields = type?.GetFields();
            var properties = type?.GetProperties();

            var _dataArrays = str.Split("\r\n");
            var _headers = _dataArrays[0].Split(",").ToList();
            var _values = _dataArrays[1].Split(",");

            foreach (var field in fields)
            {
                var i = _headers.IndexOf(field.Name);
                var val = Convert.ToInt32(_values[i]);
                field.SetValue(_f, val);
            }

            return _f;
        }

        public T DeSerialize<T>(string str)
        {

            return new F();
        }
    }
}
