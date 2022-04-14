using Microsoft.AspNetCore.Mvc;
using Assignment12._1.Models;
//step 33.6
using Microsoft.AspNetCore.Authorization;

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

        //step 40.6
        [Authorize(Roles ="Customer")]
        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Products=_tempProduct.InitializeData();
            return View(model);
        }

        //add new CRUD actions
        //step 34.6
        //step 40.6
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //step 34.6
        //step 40.6
        [Authorize(Roles = "Admin")]
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
        //step 34.6
        //step 40.6
        [Authorize(Roles = "Admin")]
        public IActionResult Update(int id)
        {
            Product obj = _tempProduct.GetProductById(id);
            return View(obj);
        }

        [HttpPost]
        //step 34.6
        //step 40.6
        [Authorize(Roles = "Admin")]
        public IActionResult Update(Product obj, int id)
        {
            obj.Id = id;
            _tempProduct.UpdateProduct(obj);
            return RedirectToAction("Index");
        }

        //step 34.6
        //step 40.6
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _tempProduct.DeleteProduct(id);
            return RedirectToAction("Index");
        }
    }
}
