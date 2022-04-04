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

        //add new CRUD actions
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            //validation attributes
            if (ModelState.IsValid)
            {
                _tempProduct.AddProduct(obj);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Product obj = _tempProduct.GetProductById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempProduct.UpdateProduct(obj);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _tempProduct.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
