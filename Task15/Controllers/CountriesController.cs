using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task15.Models.Contexts;
using Task15.Models.Entities;

namespace Task15.Controllers
{
    public class CountriesController : Controller
    {
        private readonly DataContexts db;
        public CountriesController(DataContexts db) 
        
        { 
        
          this.db=db;
        
        }
        public IActionResult Index()
        {   var Countries = db.Countries.ToList();
            return  View(Countries);
        }

        public IActionResult Details(int id)
        {
            var Country = db.Countries.Where(m=>m.Id==id).FirstOrDefault();
            return View(Country);
        }

        public IActionResult Edit(int id)
        {
            var Country = db.Countries.Where(m => m.Id == id).FirstOrDefault();
            return View(Country);


        }

        [HttpPost]
        public IActionResult Edit(Countries model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Countries model)
        {
            db.Countries.Add(model);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id)
        {
            var Country = db.Countries.Where(m => m.Id == id).FirstOrDefault();

            db.Countries.Remove(Country);
            return RedirectToAction(nameof(Index));


        }



    }
}
