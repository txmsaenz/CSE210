using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("524 Dawn Dr", "League City", "Texas", "USA");
        Customer c1 = new Customer("Timmy Nook", a1);
        List<Products> products1 = new List<Products>();
        Products p1 = new Products("Grill", "123", 150, 1);
        products1.Add(p1);
        Products p2 = new Products("Grill Tools", "987", 10, 5);
        products1.Add(p2);
        Order order1 = new Order(products1, c1);
        
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine($"Total: ${order1.TotalCost()}");
        Console.WriteLine();

        Address a2 = new Address("123 Beauty", "Vik", "Myrdal", "Iceland");
        Customer c2 = new Customer("Tommy Nook", a2);
        List<Products> products2 = new List<Products>();
        Products p3 = new Products("Wool Blanket", "456", 200, 1);
        products2.Add(p3);
        Products p4 = new Products("Winter Tools", "654", 20, 2);
        products2.Add(p4);
        Order order2 = new Order(products2, c2);

        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine($"Total: ${order2.TotalCost()}");
    }
}