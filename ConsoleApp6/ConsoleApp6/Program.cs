using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

namespace ConsoleApp6
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.Name = "Test";
            product.Description = "Test2";
            ProductToJSON(product);
            Product deserializedProduct = JsonToProduct();
            Console.WriteLine($"Id={deserializedProduct.Id}, Name={deserializedProduct.Name}, Description={deserializedProduct.Description}");

        }
        public static void ProductToJSON(Product product)
        {
            string path = @"C:\Users\Nazani\OneDrive\Masaüstü\\datanazz.dat";
            using Stream stream = new FileStream(path, FileMode.Create);
            JsonSerializer.Serialize(stream, product);
           
        }
        public static Product JsonToProduct() 
        {
            string path = @"C:\Users\Nazani\OneDrive\Masaüstü\\datanazz.dat";
            using Stream stream = new FileStream(path, FileMode.Create);
            Product product= JsonSerializer.Deserialize<Product>(stream);
            return product;

        }
    }
}
