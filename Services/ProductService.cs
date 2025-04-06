using System;

namespace WebApiWithDI.Services
{
	public class ProductService : IProductService
    {

        public IEnumerable<string> GetAllProducts()
        {
            return new List<string> { "Product1", "Product2", "Product3" };
        }

        public string GetProductById(int id)
        {
            return id switch
            {
                1 => "Product1",
                2 => "Product2",
                3 => "Product3",
                _ => "Product not found"
            };

        }
    }
}

