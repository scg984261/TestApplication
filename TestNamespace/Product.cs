namespace TestApplication.TestNamespace
{
    public class Product
    {
        public string? Name { get; set; }
        public double Price {get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
        }
    }
}
