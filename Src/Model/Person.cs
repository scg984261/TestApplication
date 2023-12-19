namespace Model
{
    public class Person : IPrintable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        

        /// <summary>
        /// Prints the Details of the Person on the System Console.
        /// </summary>
        public void PrintDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
        }
    }
}
