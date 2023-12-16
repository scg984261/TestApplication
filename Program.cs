using Model;
using TestNamespace;
using Newtonsoft.Json;
using System.Xml.Serialization;

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
            string json = JsonConvert.SerializeObject(person, Formatting.Indented);
            Console.WriteLine(json);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

            using (var stream = new StreamWriter("./output.xml"))
            {
                xmlSerializer.Serialize(stream, person);
            }
        }
    }
}
