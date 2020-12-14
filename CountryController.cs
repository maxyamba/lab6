using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab6.Models;

namespace lab6.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country/Index
        public ActionResult Index()
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.country.ToList());
            }
        }

        // GET: Country/Details/5
        public ActionResult Details(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.country.Where(x => x.id_country == id).FirstOrDefault());
            }
                
        }

        // GET: Country/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Country/Create
        [HttpPost]
        public ActionResult Create(country country)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    dbModel.country.Add(country);
                    dbModel.SaveChanges();
                }
                    // TODO: Add insert logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.country.Where(x => x.id_country == id).FirstOrDefault());
            }
            
        }

        // POST: Country/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, country country)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    dbModel.Entry(country).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Country/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.country.Where(x => x.id_country == id).FirstOrDefault());
            }

        }

        // POST: Country/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    country cnt = dbModel.country.Where(x => x.id_country == id).FirstOrDefault();
                    dbModel.country.Remove(cnt);
                    dbModel.SaveChanges();
                }
                    // TODO: Add delete logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
