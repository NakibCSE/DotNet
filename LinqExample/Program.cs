//Array , IEnumerable, IQueryable
using LinqExample;

List<string> names  = new List<string> { "Apple", "Mango", "Banana"};
List<Order> orders = new List<Order>
{
    new Order {Item = "Banana", Quantity = 10},
    new Order {Item = "Mango", Quantity = 20},
    new Order {Item = "Jackfruit", Quantity =30}
};

var quantities = (from o in orders
                  join n in names on o.Item equals n
                  select o.Quantity);

foreach (var quant in quantities)
    Console.WriteLine(quant);