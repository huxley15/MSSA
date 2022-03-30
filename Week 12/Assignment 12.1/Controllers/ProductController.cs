using Microsoft.AspNetCore.Mvc;
using Assignment12._1.Models;

namespace Assignment12._1.Controllers
{
    //step 5
    public class ProductController : Controller
    {
        private IProductRepository _tempProduct;
        public ProductController(IProductRepository tempProduct)
        {
            //dependency injection
            _tempProduct = tempProduct; 
        }
        public IActionResult Details(int? id)
        {
            var model = _tempProduct.GetProductById(id);
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products=_tempProduct.InitializeData();
            return View(model);
        }
    }
}
