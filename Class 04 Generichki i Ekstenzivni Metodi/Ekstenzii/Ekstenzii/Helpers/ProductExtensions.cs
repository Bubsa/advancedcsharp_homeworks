using Ekstenzii.Models;

namespace Ekstenzii.Helpers
{
    public static class ProductExtensions
    {
        public static void PrintInfo(this List<Product> products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine(product.GetInfo());
            }
        }
    }
}
