using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleData.Models;

namespace VehicleData.Controllers
{
    public class HomeController : Controller
    {
        employeeEntities1 db = new employeeEntities1();
        public ActionResult Index()
        {
            return View();
        }
        

        public ActionResult Userr()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Userr(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
            return View();
        }


        public ActionResult UserVehiclee()
        {
            ViewBag.UserId = new SelectList(db.Users, "ID", "FirstName");
            return View();
        }


        [HttpPost]
        public ActionResult UserVehiclee(UserVehicle uv)
        {
            db.UserVehicles.Add(uv);
            db.SaveChanges();
            return View();
        }


        public ActionResult Indexx()
        {
            var viewModel = new TravelInfoViewModel
            {
                Users = db.Users.ToList(),
                UserVehicles = db.UserVehicles.ToList(),
                TravelInfos = db.TravelInfoes.ToList()
            };

            return View(viewModel);
        }


        public ActionResult TravelInfo()
        {
            ViewBag.UserId = new SelectList(db.Users, "ID", "FirstName"); 
            ViewBag.VehicleId = new SelectList(db.UserVehicles, "ID", "VehicleModel"); 
            return View();
        }
 
        [HttpPost]
        public ActionResult TravelInfo(TravelInfo u)
        {
            db.TravelInfoes.Add(u);
            db.SaveChanges();
            return RedirectToAction("Userr", "Home"); 
        }

    }
}