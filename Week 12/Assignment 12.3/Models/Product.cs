﻿using System.ComponentModel.DataAnnotations;

namespace Assignment12._1.Models
{
    //step 1 create Product class as a model
    public enum Category
    {
        Creature,
        Concoction,
        Terror,
        Book
    }

    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        [Required]
        [MaxLength(30,ErrorMessage ="Please keep names short and sweet!")]
        public string Name { get; set; }

        [MaxLength(100,ErrorMessage ="Brevity is the soul of wit!")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageName { get; set; }
        public Category Category { get; set; }
    }
}
