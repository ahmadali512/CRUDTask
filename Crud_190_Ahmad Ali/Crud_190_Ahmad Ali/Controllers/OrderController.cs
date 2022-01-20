using CRUD_190_Ahmad_Ali.Data;
using CRUD_190_Ahmad_Ali.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CRUD_190_Ahmad_Ali.Controllers
{
    public class OrderController : Controller
    {
        private readonly StoreDB _db;
        public OrderController(StoreDB db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displaydata = _db.Orders.ToList();
            return View(displaydata);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderClass ord)
        {
            if (ModelState.IsValid)
            {
                _db.Add(ord);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return View(ord);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getorderdetails = await _db.Orders.FindAsync(id);
            return View(getorderdetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(OrderClass ord)
        {
            if (ModelState.IsValid)
            {
                _db.Update(ord);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");

            }

            return View(ord);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getorderdetails = await _db.Orders.FindAsync(id);
            return View(getorderdetails);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getorderdetails = await _db.Orders.FindAsync(id);
            return View(getorderdetails);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            var getorderdetails = await _db.Orders.FindAsync(id);
            _db.Orders.Remove(getorderdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index");

        }

    }
}
