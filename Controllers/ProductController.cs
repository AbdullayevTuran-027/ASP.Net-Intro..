using ASP.Net_MVC_Intro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ASP.Net_MVC_Intro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string search)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name ="Test 1",
                    Description = "Test 1 desc",
                    Image = "images(1).jpg",
                    Price = 100
                },
                 new Product
                {
                    Id = 1,
                    Name ="Test 2",
                    Description = "Test 2 desc",
                    Image = "images.jpg",
                    Price = 110
                },
                  new Product
                {
                    Id = 1,
                    Name ="Test 3",
                    Description = "Test 3 desc",
                    Image = "Без названия.jpg",
                    Price = 120
                }
            };
            if (string.IsNullOrEmpty(search))
            {
                products = products.FindAll(p => p.Name.ToLower().Contains(search.ToLower()));
                if(products.Count == 0)
                    return NotFound();
            }
            return View(products);
        }

    }
}
