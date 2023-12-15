namespace Model
{
    public class Person : IPrintable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        
        public void PrintDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
        }
    }
}
