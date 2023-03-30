using CartDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CartDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        CartDBContext cd = new CartDBContext();
        public string Index()
        {
            Category c = new Category()
            {
                CategoryName = "Abc"
            };
            cd.categories.Add(c);
            return "Yes";
        }
    }
}