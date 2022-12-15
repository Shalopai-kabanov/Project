using MB.Data;
using MB.Models;
using MB.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Controllers
{
    public class General_partnerController : Controller
    {
        private readonly DataDbContext _db;

        public General_partnerController(DataDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<General_partner> objList = _db.General_Partners;
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
        public IActionResult Create(General_partner obj)
        {
            if (ModelState.IsValid)
            {
                _db.General_Partners.Add(obj);
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
            var obj = _db.General_Partners.Find(id);
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
            var obj = _db.General_Partners.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.General_Partners.Remove(obj);
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
            var obj = _db.General_Partners.Find(id);
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
        public IActionResult Update(General_partner obj)
        {
            if (ModelState.IsValid)
            {
                _db.General_Partners.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
