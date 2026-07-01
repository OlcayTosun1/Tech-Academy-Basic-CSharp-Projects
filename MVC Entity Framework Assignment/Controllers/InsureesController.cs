using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureesController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insurees
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insurees/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insurees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,SpeedingTickets,DUI,CoverageType")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                decimal quote = 50m;

                int age = DateTime.Today.Year - insuree.DateOfBirth.Year;
                if (insuree.DateOfBirth.Date > DateTime.Today.AddYears(-age))
                {
                    age--;
                }

                if (age <= 18)
                {
                    quote += 100m;
                }
                else if (age >= 19 && age <= 25)
                {
                    quote += 50m;
                }
                else
                {
                    quote += 25m;
                }

                if (insuree.CarYear < 2000)
                {
                    quote += 25m;
                }

                if (insuree.CarYear > 2015)
                {
                    quote += 25m;
                }

                if (insuree.CarMake != null && insuree.CarMake.ToLower() == "porsche")
                {
                    quote += 25m;
                }

                if (insuree.CarMake != null && insuree.CarModel != null &&
                    insuree.CarMake.ToLower() == "porsche" &&
                    insuree.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25m;
                }

                quote += insuree.SpeedingTickets * 10m;

                if (insuree.DUI == true)
                {
                    quote += quote * 0.25m;
                }

                if (insuree.CoverageType == true)
                {
                    quote += quote * 0.50m;
                }

                insuree.Quote = quote;

                db.Insurees.Add(insuree);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insurees/Admin
        public ActionResult Admin()
        {
            return View(db.Insurees.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}
