using Psd_webapicrud.Model;

namespace Psd_webapicrud.Data
{
    public static class ProductData
    {
        public static List<Product> Products = new List<Product>
    {
        new Product { Id = 1, Name = "Laptop", Price = 1000 },
        new Product { Id = 2, Name = "Smartphone", Price = 500 }
    };
    }

}
