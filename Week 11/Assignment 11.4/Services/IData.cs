using System.Collections.Generic;
using Assignment11._4.Model;

namespace Assignment11._4.Services
    
{
    public interface IData
    {
        IEnumerable<Product> GetAll();
        Product GetProduct(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
