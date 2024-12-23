using System.Reflection;

Assembly a = Assembly.GetExecutingAssembly();
var types = a.GetTypes();

foreach(Type t in types)
{
    Console.WriteLine(t.FullName);
}