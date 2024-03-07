using otus_Reflection.Services;

TimeWatch timeWatch = new TimeWatch();

Console.WriteLine(timeWatch.ShowCustomeSerializeTimeCSV());
Console.ReadKey();

Console.WriteLine(timeWatch.ShowCustomeDeserializeTimeCSV());
Console.ReadKey();

Console.WriteLine(timeWatch.ShowNewtonsoftJsonSerializeTime());
Console.ReadKey();

Console.WriteLine(timeWatch.ShowNewtonsoftJsonDeserializeTime());
Console.ReadKey();



Console.WriteLine(timeWatch.ShowCsvSerializationResult());
Console.WriteLine(timeWatch.ShowJsonSerializationResult());
Console.ReadKey();
