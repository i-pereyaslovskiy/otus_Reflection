using otus_Reflection.Interface;
using System.Reflection;
using System.Text;

namespace otus_Reflection.Reflection.Serialize
{
    internal class CsvSerialize : ISerializer
    {
        public string Serialize<T>(T obj)
        {
            const string Separator = ",";
         

            var type = obj?.GetType();
            var members = type?.GetMembers();

            StringBuilder sbHeaders = new StringBuilder();
            StringBuilder sbValues = new StringBuilder();

            foreach (var member in members) { 
         
                if(member.MemberType == MemberTypes.Field || member.MemberType == MemberTypes.Property)
                {
                    sbHeaders.Append($"{member.Name}{Separator}");

                    if (member.MemberType == MemberTypes.Field)
                        sbValues.Append($"{type.GetField(member.Name).GetValue(obj)}{Separator}");
                    else
                        sbValues.Append($"{type.GetProperty(member.Name).GetValue(obj)}{Separator}");
                }

            }

            sbHeaders.Length--;
            sbValues.Length--;


            return sbHeaders.
                AppendLine().
                Append(sbValues).ToString();
        }
    }
}
