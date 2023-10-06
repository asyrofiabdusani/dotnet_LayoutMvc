using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LayoutMvc.Models;

namespace LayoutMvc.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(int? id)
        {
            //var product = new Product()
            //{
            //    Id = 1,
            //    Name = "Product name",
            //    Description = "This is description",
            //    Category = "F&B",
            //    Price = 200000
            //};
            var products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "Product 1",
                Category = "F&B",
                Description = "This is product 1",
                Price = 20000,
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Product 2",
                Category = "H&L",
                Description = "This is product 2",
                Price = 500000,
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Product 3",
                Category = "H&L",
                Description = "This is product 3",
                Price = 600000,
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Product 4",
                Category = "H&L",
                Description = "This is product 4",
                Price = 900000,
            });
            products.Add(new Product()
            {
                Id = 5,
                Name = "Product 5",
                Category = "H&L",
                Description = "This is product 5",
                Price = 900000,
            });
            products.Add(new Product()
            {
                Id = 6,
                Name = "Product 6",
                Category = "H&L",
                Description = "This is product 6",
                Price = 600000,
            });
            products.Add(new Product()
            {
                Id = 7,
                Name = "Product 7",
                Category = "H&L",
                Description = "This is product 7",
                Price = 700000,
            });
            products.Add(new Product()
            {
                Id = 8,
                Name = "Product 8",
                Category = "H&L",
                Description = "This is product 8",
                Price = 800000,
            });
            products.Add(new Product()
            {
                Id = 9,
                Name = "Product 9",
                Category = "H&L",
                Description = "This is product 9",
                Price = 900000,
            });
            if (id != null)
            {
                var result = new List<Product>();
                foreach (var item in products)
                {
                    if (item.Id == id)
                    {
                        result.Add(item);
                        return View(result);
                    }
                }
            }
            else
            {
                return View(products);
            }
            return View();
        }

        public ActionResult Input()
        {
            return View();
        }
        [HttpPost]
        //public ActionResult Input(Product dataInput)
        //{
        //    return Content("Data Input : " + dataInput.Id + "," + dataInput.Name + "," + dataInput.Description + "," + dataInput.Category + "," + dataInput.Price);
        //}
        public ActionResult Input([Bind(Include = "Id, Name")] Product prod)
        {
            return Content(prod.Name);
        }
    }
}