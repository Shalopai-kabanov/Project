using MB.Data;
using MB.Models;
using MB.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MB.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly DataDbContext _db;

        public ApartmentController(DataDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Apartment> objList = _db.Apartments;

            foreach(var obj in objList)
            {
                obj.Type_of_apartment = _db.Type_Of_Apartments.FirstOrDefault(u => u.Id == obj.Type_of_apartment_id);
                obj.Hotel = _db.Hotels.FirstOrDefault(u => u.Id == obj.Type_of_apartment_id);
            }
            return View(objList);
        }

        //GET-CREATE
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            ApartmentVM apartmentVM = new ApartmentVM()
            {
                Apartment = new Apartment(),
                TDDHotel = _db.Hotels.Select(i => new SelectListItem
                {
                    Text = i.Hotel_name,
                    Value = i.Id.ToString()
                }),
                TDDType_of_apartment = _db.Type_Of_Apartments.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };

            return View(apartmentVM);
        }

        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public IActionResult Create(ApartmentVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Apartments.Add(obj.Apartment);
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
            var obj = _db.Apartments.Find(id);
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
            var obj = _db.Apartments.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Apartments.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET-UPDATE
        [Authorize(Roles = "admin, moderator")]
        public IActionResult Update(int? id)
        {
            ApartmentVM apartmentVM = new ApartmentVM()
            {
                Apartment = new Apartment(),
                TDDHotel = _db.Hotels.Select(i => new SelectListItem
                {
                    Text = i.Hotel_name,
                    Value = i.Id.ToString()
                }),
                TDDType_of_apartment = _db.Type_Of_Apartments.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                }),
            };

            if (id == null || id == 0)
            {
                return NotFound();
            }
            apartmentVM.Apartment = _db.Apartments.Find(id);
            if (apartmentVM.Apartment == null)
            {
                return NotFound();
            }
            return View(apartmentVM);
        }

        //POST UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, moderator")]
        public IActionResult Update(ApartmentVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Apartments.Update(obj.Apartment);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var apartment = await _db.Apartments.Include(b => b.Hotel).Include(c => c.Type_of_apartment)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (apartment == null)
            {
                return NotFound();
            }

            return View(apartment);

        }
    }
}
