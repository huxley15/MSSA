using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment12._1.Models
{
    //step 1.2
    public class ProductCategory
    {
        //step 2.2
        [Key]
        public int CatId { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
