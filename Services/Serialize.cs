using otus_Reflection.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Services
{
    internal class Serialize : ISerialize
    {
        public string SerializeToCSV<T>(T fClass)
        {

            const string Separator = ",";
            var type = fClass?.GetType();
            var fields = type?.GetFields();

            StringBuilder sb = new StringBuilder();

            foreach (var field in fields)
                sb.Append($"{field.Name}{Separator}");

            --sb.Length;
            sb.AppendLine();

            foreach (var field in fields)
                sb.Append($"{field.GetValue(fClass)}{Separator}");

            --sb.Length;

            return sb.ToString();
        }

    }
}
