using System.Collections.Generic;

namespace Assignment12._1.Models
{
    //step 3
    public class ProductRepository : IProductRepository
    {
        public List<Product> Products { get; set; }

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
            Products = new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Rat on Stilts",
                    Description = "50% anger, 50% tremble",
                    Price = 666.13M,
                    ImageName = "chihuahua.jpg"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Demon Fuel",
                    Description = "Liquid Deficate",
                    Price = 4.20M,
                    ImageName = "coffee.png"
                },
                new Product()
                {
                    Id = 3,
                    Name = "Today's Mood",
                    Description = "I spend my lunch breaks pondering my life choices",
                    Price = 0.11M,
                    ImageName = "numbers.png"
                }
            };
            return Products;
            
        }
    }
}
