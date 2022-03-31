using Microsoft.EntityFrameworkCore;

namespace Assignment12._1.Models
{
    //step 3.2
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set;}
        public DbSet<ProductCategory> ProductCategories { get; set;}

        //step 4.2 data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Rat on Stilts",
                    Description = "50% anger, 50% tremble",
                    Price = 666.13M,
                    ImageName = "chihuahua.jpg",
                    Category = Category.Creature,
                    CatId = 1,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Demon Fuel",
                    Description = "Liquid Deficate",
                    Price = 4.20M,
                    ImageName = "coffee.png",
                    Category = Category.Concoction,
                    CatId= 2,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Today's Mood",
                    Description = "I spend my lunch breaks pondering my life choices",
                    Price = 0.11M,
                    ImageName = "numbers.png",
                    Category = Category.Terror,
                    CatId = 3
                }
                );
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory()
                {
                    CatId = 1,
                    CategoryName = "Creature"
                },
                new ProductCategory()
                {
                    CatId = 2,
                    CategoryName = "Concoction"
                },
                new ProductCategory()
                {
                    CatId = 3,
                    CategoryName = "Terror"
                },
                new ProductCategory()
                {
                    CatId = 4,
                    CategoryName = "Book"
                }
                );
        }
    }
}
