using otus_Reflection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Reflection.Serialize
{
    internal class CsvSerializer : ISerializer
    {
        public string Serialize<T>(T obj)
        {
            const string Separator = ",";
            
            var type = obj?.GetType();
            var fields = type?.GetFields();
            var properties = type?.GetProperties();

            StringBuilder sb = new StringBuilder();

            if (fields?.Length > 0)
                foreach (var field in fields)
                    sb.Append($"{field.Name}{Separator}");

            if(properties?.Length > 0)
                foreach (var property in properties)
                    sb.Append($"{property.Name}{Separator}");

            sb.Length--;
            sb.AppendLine();

            if (fields?.Length > 0)
                foreach (var field in fields)
                    sb.Append($"{field.GetValue(obj)}{Separator}");
            
            if (properties?.Length > 0)
                foreach (var property in properties)
                    sb.Append($"{property.GetValue(obj)}{Separator}");

            sb.Length--;
            
            return sb.ToString();
        }
    }
}
