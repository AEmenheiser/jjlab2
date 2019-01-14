using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabJJ2.Models;

namespace LabJJ2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MainPage()
        {
            return View();
        }
        public ActionResult Success()
        {
            return View();
        }

        public ActionResult Edit(ProductsClass model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index", model);
        }
    }
}