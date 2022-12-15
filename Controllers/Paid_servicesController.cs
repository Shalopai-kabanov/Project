using MB.Data;
using MB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Controllers
{
    public class Paid_servicesController : Controller
    {
        private readonly DataDbContext _db;

        public Paid_servicesController(DataDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Paid_services> objList = _db.Paid_Services;
            return View(objList);
        }

        //GET-CREATE
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            return View();
        }

        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public IActionResult Create(Paid_services obj)
        {
            if (ModelState.IsValid)
            {
                _db.Paid_Services.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET-DELETE
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Paid_Services.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST-DELETE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.Paid_Services.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Paid_Services.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET-UPDATE
        [Authorize(Roles = "admin, moderator")]
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Paid_Services.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, moderator")]
        public IActionResult Update(Paid_services obj)
        {
            if (ModelState.IsValid)
            {
                _db.Paid_Services.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
