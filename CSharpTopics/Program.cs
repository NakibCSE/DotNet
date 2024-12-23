using System.Reflection;

Assembly a = Assembly.GetExecutingAssembly();
var types = a.GetTypes();

foreach (Type t in types)
{
    var interfaces = t.GetInterfaces();
    if (interfaces.Any(x => x.Name == "IPurchaseable"))
    { 
        ConstructorInfo constructor = t.GetConstructor([typeof(string), typeof(double)])
    }
}