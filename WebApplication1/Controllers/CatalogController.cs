using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CatalogController : Controller
    {
        private IEnumerable category;

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }


        public ActionResult Product()
        {
     

            return View();
        }

        private IEnumerable<SelectListItem> GetProduct()
        {
            category = new List<Category>()
            {
             new Category   { Id = 1, Name = "Groceries"},
             new Category   { Id = 2, Name = "Groceries"},
             new Category   { Id = 3, Name = "Groceries"},
            };
            return new SelectList(category, "Id", "Name");
        }

    }
}