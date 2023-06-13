using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();

        public void CreateProduct(string name, double price, int categoryID,  int onSale, int stockLevel);
        public Product GetProductById(int id);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}
