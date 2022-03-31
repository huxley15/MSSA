using System.Collections.Generic;

namespace Assignment12._1.Models
{
    //step 3
    public class ProductRepository : IProductRepository
    {
        public List<Product> Products { get; set; }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(int? id)
        {
            var prod = Products.Find(x => x.Id == id);
            Products.Remove(prod);
        }

        public ProductRepository()
        {
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Rat on Stilts",
                    Description = "50% anger, 50% tremble",
                    Price = 666.13M,
                    ImageName = "chihuahua.jpg",
                    Category = Category.Creature
                },
                new Product()
                {
                    Id = 2,
                    Name = "Demon Fuel",
                    Description = "Liquid Deficate",
                    Price = 4.20M,
                    ImageName = "coffee.png",
                    Category=Category.Concoction
                },
                new Product()
                {
                    Id = 3,
                    Name = "Today's Mood",
                    Description = "I spend my lunch breaks pondering my life choices",
                    Price = 0.11M,
                    ImageName = "numbers.png",
                    Category=Category.Terror
                }
            };
        }

        public Product GetProductById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return Products.Find(x => x.Id == id);
            }
        }

        public List<Product> InitializeData()
        {
            
            return Products;
            
        }

        public void UpdateProduct(Product product)
        {
            var prod = Products.Find(x=>x.Id == product.Id);
            if (prod != null)
            {
                prod.Id = product.Id;
                prod.Name = product.Name;
                prod.Description = product.Description;
                prod.Price = product.Price;
                prod.ImageName = product.ImageName;
                prod.Category = product.Category;
            }
        }
    }
}
