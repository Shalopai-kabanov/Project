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
    public class Partner_typeController : Controller
    {
        private readonly DataDbContext _db;

        public Partner_typeController(DataDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Partner_type> objList = _db.Partner_Types;
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
        public IActionResult Create(Partner_type obj)
        {
            if (ModelState.IsValid)
            {
                _db.Partner_Types.Add(obj);
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
            var obj = _db.Partner_Types.Find(id);
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
            var obj = _db.Partner_Types.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Partner_Types.Remove(obj);
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
            var obj = _db.Partner_Types.Find(id);
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
        public IActionResult Update(Partner_type obj)
        {
            if (ModelState.IsValid)
            {
                _db.Partner_Types.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
