using otus_Reflection;
using otus_Reflection.Models;
using otus_Reflection.Services;
using otus_Reflection.Storage;

TimeWatch timeWatch = new TimeWatch();

Console.WriteLine(timeWatch.ShowCustomeSerializeTimeCSV());
Console.ReadKey();

Console.WriteLine(timeWatch.ShowCustomeDeserializeTimeCSV());
Console.ReadKey();

//Console.WriteLine(timeWatch.ShowNewtonsoftJsonSerializeTime());
//Console.ReadKey();

//Console.WriteLine(timeWatch.ShowNewtonsoftJsonDeserializeTime());
//Console.ReadKey();
