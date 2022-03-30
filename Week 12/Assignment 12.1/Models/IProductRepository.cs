using System.Collections.Generic;

namespace Assignment12._1.Models
{
    //step 2
    public interface IProductRepository
    {
        List<Product> Products { get; set; }
        List<Product> InitializeData();
        Product GetProductById(int? id);
    }
}
