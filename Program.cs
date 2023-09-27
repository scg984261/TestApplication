using Model;
using TestNamespace;

namespace TestApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var product = new Product("Book", 9.5);
            product.PrintDetails();

            var person = new Person
            {
                Id = 1,
                Name = "John"
            };

            person.PrintDetails();
        }
    }
}
