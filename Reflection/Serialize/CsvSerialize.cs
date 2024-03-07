using otus_Reflection.Interface;
using System.Reflection;
using System.Text;

namespace otus_Reflection.Reflection.Serialize
{
    internal class CsvSerialize : ISerializer
    {
        public string Serialize<T>(T obj)
        {
            const char Separator = ',';
         

            var type = obj?.GetType();
            var members = type?.GetMembers();

            StringBuilder sBuilder = new StringBuilder();

            List<string> headers = new List<string>();
            List<string> values = new List<string>();

            foreach (var member in members) { 
         
                if(member.MemberType == MemberTypes.Field || member.MemberType == MemberTypes.Property)
                {
                    headers.Add(member.Name);

                    if (member.MemberType == MemberTypes.Field)
                        values.Add($"{type.GetField(member.Name).GetValue(obj)}");
                    else
                        values.Add($"{type.GetProperty(member.Name).GetValue(obj)}");
                }

            }

            return sBuilder.
                AppendJoin(Separator, headers).
                AppendLine().
                AppendJoin(Separator, values).
                ToString();
        }
    }
}
