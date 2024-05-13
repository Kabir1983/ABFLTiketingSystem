using App03.Models;
using Microsoft.AspNetCore.Mvc;

namespace App03.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Index()
        {
            int[] myData = { 45, 58, 45, 89, 98 };

            ViewData["abc"] = myData;
            ViewData["msg"] = "Asp.Net Core MVC Application => View Data Practice";


            ViewBag.abc = myData;
            ViewBag.msg2 = "Asp.Net Core MVC Application => View Bag Prcatice.";

            return View();
        }

        public IActionResult ShowProduct()
        {
            List<Product> productList = new List<Product>()
            {
                new Product() { Id = 1, Name = "Shirt", Price = 100, Quantity = 3, Unit = "Pcs" },
                new Product() { Id = 2, Name = "T-Shirt", Price = 45, Quantity = 6, Unit = "Pcs" },
                new Product() { Id = 3, Name = "Pant", Price = 244, Quantity = 8, Unit = "Pcs" },
                new Product() { Id = 4, Name = "Blazer", Price = 50, Quantity = 6, Unit = "Pcs" },
                new Product() { Id = 5, Name = " Formal wear", Price = 50, Quantity = 6, Unit = "Pcs" },
                new Product() { Id = 6, Name = " Kurti", Price = 5, Quantity = 6, Unit = "Pcs" },
            };

            ViewBag.garmentsProduct= productList;

            return View();
        }

        public IActionResult ShowProduct2()
        {
            List<Product> productList = new List<Product>()
            {
                new Product() { Id = 1, Name = "Shirt", Price = 100, Quantity = 3, Unit = "Pcs" },
                new Product() { Id = 2, Name = "T-Shirt", Price = 45, Quantity = 6, Unit = "Pcs" },
                new Product() { Id = 3, Name = "Pant", Price = 244, Quantity = 8, Unit = "Pcs" },
                new Product() { Id = 4, Name = "Blazer", Price = 50, Quantity = 6, Unit = "Pcs" },
                new Product() { Id = 5, Name = " Formal wear", Price = 50, Quantity = 6, Unit = "Pcs" },
                new Product() { Id = 6, Name = " Kurti", Price = 5, Quantity = 6, Unit = "Pcs" },
            };

            return View(productList);
        }
    }

}