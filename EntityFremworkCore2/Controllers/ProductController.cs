using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFremworkCore2.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFremworkCore2.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;


        public ProductController(IProductRepository repo)
        {
         
            repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult List() => View(repository.Products);

    }
}