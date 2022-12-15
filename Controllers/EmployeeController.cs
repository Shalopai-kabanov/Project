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
    public class EmployeeController : Controller
    {
        private readonly DataDbContext _db;

        public EmployeeController(DataDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Employee> objList = _db.Employees;

            foreach (var obj in objList)
            {
                obj.Role = _db.Roles.FirstOrDefault(u => u.Id == obj.Role_id);
                obj.Hotel = _db.Hotels.FirstOrDefault(u => u.Id == obj.Hotel_id);
            }

            return View(objList);
        }

        //GET-CREATE
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            EmployeeVM employeeVM = new EmployeeVM()
            {
                Employee = new Employee(),
                TDDHotel = _db.Hotels.Select(i => new SelectListItem
                {
                    Text = i.Hotel_name,
                    Value = i.Id.ToString()
                }),
                TDDRole = _db.Roles.Select(i => new SelectListItem
                {
                    Text = i.Name_of_role,
                    Value = i.Id.ToString()
                }),
            };

            return View(employeeVM);
        }

        //POST-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")]
        public IActionResult Create(EmployeeVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(obj.Employee);
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
            var obj = _db.Employees.Find(id);
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
            var obj = _db.Employees.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Employees.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET-UPDATE
        [Authorize(Roles = "admin, moderator")]
        public IActionResult Update(int? id)
        {
            EmployeeVM employeeVM = new EmployeeVM()
            {
                Employee = new Employee(),
                TDDHotel = _db.Hotels.Select(i => new SelectListItem
                {
                    Text = i.Hotel_name,
                    Value = i.Id.ToString()
                }),
                TDDRole = _db.Roles.Select(i => new SelectListItem
                {
                    Text = i.Name_of_role,
                    Value = i.Id.ToString()
                }),
            };

            if (id == null || id == 0)
            {
                return NotFound();
            }
            employeeVM.Employee = _db.Employees.Find(id);
            if (employeeVM.Employee == null)
            {
                return NotFound();
            }
            return View(employeeVM);
        }

        //POST UPDATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin, moderator")]
        public IActionResult Update(EmployeeVM obj)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Update(obj.Employee);
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

            var employee = await _db.Employees.Include(b => b.Hotel).Include(c => c.Role)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);

        }
    }
}
