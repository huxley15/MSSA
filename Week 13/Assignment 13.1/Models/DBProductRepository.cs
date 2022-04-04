using System.Collections.Generic;

namespace Assignment12._1.Models
{
    //step 5.2
    public class DBProductRepository : IProductRepository
    {
        public List<Product> Products { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        private ProductContext _productContext;
        public DBProductRepository(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public void AddProduct(Product product)
        {
            if (product.Category.ToString() == "Creature")
            {
                product.CatId = 1;
            }
            if (product.Category.ToString() == "Concoction")
            {
                product.CatId = 2;
            }
            if (product.Category.ToString() == "Terror")
            {
                product.CatId = 3;
            }
            if (product.Category.ToString() == "Book")
            {
                product.CatId = 4;
            }
            
            _productContext.Products.Add(product);
            _productContext.SaveChanges();
        }

        public void DeleteProduct(int? id)
        {
            var prod = _productContext.Products.Find(id);
            if (prod != null)
            {
                _productContext.Products.Remove(prod);
                _productContext.SaveChanges();
            }
        }

        public Product GetProductById(int? id)
        {
            return _productContext.Products.Find(id);
        }

        public IEnumerable<Product> InitializeData()
        {
            return _productContext.Products;
        }

        public void UpdateProduct(Product product)
        {
            Product prod = _productContext.Products.Find(product.Id);
            if (prod != null)
            {
                prod.Id = product.Id;
                prod.Name = product.Name;
                prod.Description = product.Description;
                prod.Category = product.Category;
                prod.Price = product.Price;
                prod.ImageName = product.ImageName;
                if (product.Category.ToString() == "Creature")
                {
                    prod.CatId = 1;
                }
                if (product.Category.ToString() == "Concoction")
                {
                    prod.CatId = 2;
                }
                if (product.Category.ToString() == "Terror")
                {
                    prod.CatId = 3;
                }
                if (product.Category.ToString() == "Book")
                {
                    prod.CatId = 4;
                }
                _productContext.SaveChanges();
            }
        }
    }
}
