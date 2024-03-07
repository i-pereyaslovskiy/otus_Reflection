using otus_Reflection.Interface;
using otus_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Reflection.Deserialize
{
    internal class CsvDeserialize : IDeserializer
    {
        public T Deserialize<T>(string str)
        {
            Type type = typeof(T);
            var members = type?.GetMembers();
            var instance = (T)Activator.CreateInstance(type);


            var _dataArrays = str.Split("\r\n");
            var _headers = _dataArrays[0].Split(",").ToList();
            var _values = _dataArrays[1].Split(",");

            foreach (var member in members)
            {
                if (member.MemberType == MemberTypes.Field || member.MemberType == MemberTypes.Property)
                {
                    if (member.MemberType == MemberTypes.Field)
                    {
                        var i = _headers.IndexOf(member.Name);
                        var val = Convert.ToInt32(_values[i]);
                        type.GetField(member.Name).SetValue(instance, val);
                    }
                    else
                    {
                        var i = _headers.IndexOf(member.Name);
                        var val = Convert.ToInt32(_values[i]);
                        type.GetProperty(member.Name).SetValue(instance, val);
                    }
                }
            }

            return instance;
        }

     
    }
}
