using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Storage
{
    public static class StringsStorage
    {
        public static string GetStringCSV()
        {
            return "i1,i2,i3,i4,i5\r\n1,2,3,4,5";
        } 

        public static string GetStringJSON()
        {
            return "{\"i1\":1,\"i2\":2,\"i3\":3,\"i4\":4,\"i5\":5}";
        }
    }
}
