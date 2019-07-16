using GarrettVidly.Models;
using GarrettVidly.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarrettVidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }


        [Route("Customers/Details/{Id}")]
        public ActionResult Details(int Id)
        {
            var selectedCustomer = _context.Customers.FirstOrDefault(x => x.Id == Id);
            if (selectedCustomer == null)
            {
                return HttpNotFound();
            }
            return View(selectedCustomer);
        }

        [Route("Customers/Edit/{test}")]
        public ActionResult Edit(string test)
        {

            return View();
        }
    }
}