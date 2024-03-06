using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Models
{
    public class F
    {
        public int i1 { get; set; }
        public int i2 { get; set; }
        
        public int i3;
        public int i4;
        public int i5;

        public F Get() => new() { i1 = 1, i2 = 2, i3 = 3, i4 = 4, i5 = 5 };
    }
}
