using lab6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab6.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.city.ToList());
            }
        }

        // GET: City/Details/5
        public ActionResult Details(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.city.Where(x => x.id_city == id).FirstOrDefault());
            }
        }

        // GET: City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City/Create
        [HttpPost]
        public ActionResult Create(city city)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    dbModel.city.Add(city);
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

        // GET: City/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.city.Where(x => x.id_city == id).FirstOrDefault());
            }
        }

        // POST: City/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, city city)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    dbModel.Entry(city).State = EntityState.Modified;
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

        // GET: City/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.city.Where(x => x.id_city == id).FirstOrDefault());
            }
        }

        // POST: City/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    city cnt = dbModel.city.Where(x => x.id_city == id).FirstOrDefault();
                    dbModel.city.Remove(cnt);
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
