using otus_Reflection.Models;
using otus_Reflection.Reflection.Serialize;
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
        private CsvSerializer _csvSerializer;
        private JsonSerializer _jsonSerializer;
        
            
        private DeSerialize _deSerialize;
        private Stopwatch _stopwatch;
        private const int _ITERATIONS = 1;

        public TimeWatch()
        {
            _f = new F().Get();
            _csvSerializer = new CsvSerializer();
            _jsonSerializer = new JsonSerializer();

            _deSerialize = new DeSerialize();
            _stopwatch = new Stopwatch();
        }

        public string ShowCustomeSerializeTimeCSV() {
            _stopwatch.Start();

            string str = "";
            for (int i = 0; i < _ITERATIONS; i++)
                str = _csvSerializer.Serialize(_f);

            _stopwatch.Stop();
            return str;
            //return $"My Custom CSV Serilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
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
                str = _jsonSerializer.Serialize(_f);

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
