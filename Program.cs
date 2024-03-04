using otus_Reflection;
using otus_Reflection.Services;

F f = new F();
Serialize serialize = new Serialize();

F newF = f.Get();
var h = serialize.SerializeCSV(newF);
var k = serialize.SerializeNewtonsoftJson(newF);

Console.WriteLine(h);
Console.ReadKey();