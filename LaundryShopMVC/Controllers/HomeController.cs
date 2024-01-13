using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Mvc;
using LaundryShopMVC.Models;

namespace LaundryShopMVC.Controllers
{
    public class HomeController : Controller
    {
        Repository repository = new Repository();
        
        public ActionResult Index()
        {
            var data = repository.GetList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            Customer customer = new Customer();
            ViewBag.hint = "Delivery date is after 7 days form order";
           
            customer.invoices.Add(new Invoice());
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                repository.Save(customer);
                return RedirectToActionPermanent("Index");
            }
            return View(customer);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var customer = repository.Get(id);
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                repository.Update(customer);
                return RedirectToActionPermanent("Index");
            }
            return View(customer);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var customer = repository.Get(id);
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete([Form] Customer customer)
        {

            repository.Delete(customer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {

            var customer = repository.Get(id);
            return View(customer);

        }
    }
}