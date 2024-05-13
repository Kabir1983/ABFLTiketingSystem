using Microsoft.AspNetCore.Mvc;
using ProductInfo.Models;

namespace ProductInfo.Controllers
{
    public class ProductController : Controller
    {
        List<Product> productList = new List<Product>();
        public IActionResult ProductList()
        {
            productList.Add(new Product() { Id = 1, Name = "Mum Drinking Water", Description = "Water", Price = 20, Brand = "Mum" });
            productList.Add(new Product() { Id = 2, Name = "Fresh Drinking Water", Description = "Water", Price = 20, Brand = "Fresh" });
            productList.Add(new Product() { Id = 3, Name = "Fresh Salt", Description = "Salt", Price = 50, Brand = "Fresh" });
            productList.Add(new Product() { Id = 4, Name = "Fresh Flour", Description = "Atta", Price = 60, Brand = "Fresh" });
            productList.Add(new Product() { Id = 5, Name = "Fresh Checken Noodles", Description = "Noodles", Price = 60, Brand = "Fresh" });
            productList.Add(new Product() { Id = 6, Name = "Fresh Sugar", Description = "Sugar", Price = 60, Brand = "Fresh" });

            ViewBag.ProductList = productList;

            return View();
        }


        public IActionResult CreateProduct(Product objProduct)
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewProduct(Product objProduct)
        {
            objProduct.Id = productList.Count + 1;
            productList.Append(objProduct);
            return RedirectToAction("ProductList");
        }
    }
}
