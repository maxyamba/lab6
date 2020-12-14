using lab6.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab6.Controllers
{
    public class CinemaController : Controller
    {
        // GET: Cinema
        public ActionResult Index()
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.cinema.ToList());
            }
        }

        // GET: Cinema/Details/5
        public ActionResult Details(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.cinema.Where(x => x.id_cinema == id).FirstOrDefault());
            }
        }

        // GET: Cinema/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cinema/Create
        [HttpPost]
        public ActionResult Create(cinema cinema)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    dbModel.cinema.Add(cinema);
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

        // GET: Cinema/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.cinema.Where(x => x.id_cinema == id).FirstOrDefault());
            }
        }

        // POST: Cinema/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, cinema cinema)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    dbModel.Entry(cinema).State = EntityState.Modified;
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

        // GET: Cinema/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModel dbModel = new DbModel())
            {
                return View(dbModel.cinema.Where(x => x.id_cinema == id).FirstOrDefault());
            }
        }

        // POST: Cinema/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModel dbModel = new DbModel())
                {
                    cinema cnm = dbModel.cinema.Where(x => x.id_cinema == id).FirstOrDefault();
                    dbModel.cinema.Remove(cnm);
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
