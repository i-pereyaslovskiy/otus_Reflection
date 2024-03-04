using otus_Reflection.Models;
using otus_Reflection.Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace otus_Reflection.Services
{
    internal class TimeWatch
    {
        private F _f;
        private Serialize _serialize;
        private DeSerialize _deSerialize;
        private Stopwatch _stopwatch;
        private const int _ITERATIONS = 10000;

        public TimeWatch()
        {
            _f = new F().Get();
            _serialize = new Serialize();
            _deSerialize = new DeSerialize();
            _stopwatch = new Stopwatch();
        }

        public string ShowCustomeSerializeTimeCSV() {
            _stopwatch.Start();

            string str;
            for (int i = 0; i < _ITERATIONS; i++)
                str = _serialize.SerializeCSV(_f);

            _stopwatch.Stop();
            return $"My Custom CSV Serilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
        }
        public string ShowCustomeDeserializeTimeCSV() {
            _stopwatch.Start();

            F f;
            for (int i = 0; i < _ITERATIONS; i++)
               f = _deSerialize.DeSerializeCSV(StringsStorage.GetStringCSV());

            _stopwatch.Stop();
            return $"My Custom CSV Deserilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
        }

        public string ShowNewtonsoftJsonSerializeTime()
        {
            _stopwatch.Start();

            string str;
            for (int i = 0; i < _ITERATIONS; i++)
                str = _serialize.SerializeNewtonsoftJson(_f);

            _stopwatch.Stop();
            return $"NewtonsoftJson Serilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
        }
        public string ShowNewtonsoftJsonDeserializeTime()
        {
            _stopwatch.Start();

            F f;
            for (int i = 0; i < _ITERATIONS; i++)
                f = _deSerialize.DeSerializeNewtonsoftJson(StringsStorage.GetStringJSON());

            _stopwatch.Stop();
            return $"NewtonsoftJson Deserilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
        }

    }
}
