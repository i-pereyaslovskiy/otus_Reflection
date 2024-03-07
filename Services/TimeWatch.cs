using otus_Reflection.Models;
using otus_Reflection.Reflection.Deserialize;
using otus_Reflection.Reflection.Serialize;
using System.Diagnostics;

namespace otus_Reflection.Services
{
    internal class TimeWatch
    {
        private F _f;
        private CsvSerialize _csvSerializer;
        private JsonSerialize _jsonSerializer;
            
        private CsvDeserialize _csvDeserialize;
        private JsonDeserialize _jsonDeserialize;

        private Stopwatch _stopwatch;
        private const int _ITERATIONS = 10000;

        string strCsvSerializationResult = "";
        string strJsonSerializationResult = "";

        public TimeWatch()
        {
            _f = new F().Get();
            _csvSerializer = new CsvSerialize();
            _jsonSerializer = new JsonSerialize();

            _csvDeserialize = new CsvDeserialize();
            _jsonDeserialize = new JsonDeserialize();
           
            _stopwatch = new Stopwatch();
        }

        public string ShowCustomeSerializeTimeCSV() {
            _stopwatch.Start();

            
            for (int i = 0; i < _ITERATIONS; i++)
                strCsvSerializationResult = _csvSerializer.Serialize(_f);

            _stopwatch.Stop();
            return $"My Custom CSV Serilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
        }
        public string ShowCustomeDeserializeTimeCSV() {
            _stopwatch.Start();

            F f;
            for (int i = 0; i < _ITERATIONS; i++)
               f = _csvDeserialize.Deserialize<F>(strCsvSerializationResult);

            _stopwatch.Stop();
            return $"My Custom CSV Deserilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
        }

        public string ShowNewtonsoftJsonSerializeTime()
        {
            _stopwatch.Start();

            for (int i = 0; i < _ITERATIONS; i++)
                strJsonSerializationResult = _jsonSerializer.Serialize(_f);

            _stopwatch.Stop();
            return $"NewtonsoftJson Serilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
        }
        public string ShowNewtonsoftJsonDeserializeTime()
        {
            _stopwatch.Start();

            F f;
            for (int i = 0; i < _ITERATIONS; i++)
                f = _jsonDeserialize.Deserialize<F>(strJsonSerializationResult);

            _stopwatch.Stop();
            return $"NewtonsoftJson Deserilization lasted: {_stopwatch.ElapsedMilliseconds} ms";
        }


        #region  ShowSerializationResult
        public string ShowCsvSerializationResult() {
            return $"\r\nCsv serialized object:\r\n{strCsvSerializationResult}\r\n";
        }
        public string ShowJsonSerializationResult()
        {
            return $"Json serialized object:\r\n{strJsonSerializationResult}\r\n";
        }
        #endregion
    }
}
