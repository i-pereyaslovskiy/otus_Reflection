using otus_Reflection;
using otus_Reflection.Services;

F f = new F();
Serialize serialize = new Serialize();

F newF = f.Get();
var h = serialize.SerializeToCSV(newF);
Console.WriteLine(h);
Console.ReadKey();