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



        public IActionResult List() {



            var urun=repository.Products;

            return View(urun);

        }





        [HttpGet]
        public IActionResult Create( )
        {



            

            return View();

        }


        public IActionResult Create(Product product)
        {



            repository.CreateProduct(product);
            

            return View();

        }


        public IActionResult Details(int  id)
        {

            var urun = repository.GetById(id);

          


            return View(urun);

        }


        public IActionResult Edit(int id)
        {

            var urun = repository.GetById(id);




            return View(urun);

        }

        [HttpPost]
        public IActionResult Edit(Product model)
        {
            repository.UpdateProduct(model);



        

            return RedirectToAction("List");

        }


        public IActionResult Delete(int  id)
        {


             var deger= repository.GetById(id);

               repository.Delete(id);



            return RedirectToAction("List");

        }



    }
}