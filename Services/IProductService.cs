using System;
namespace WebApiWithDI.Services
{
	public interface IProductService
	{
        IEnumerable<string> GetAllProducts();
        string GetProductById(int id);
        
	}
}

