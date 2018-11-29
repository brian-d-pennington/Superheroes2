using Superheroes2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes2.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Superhero
        public ActionResult Index()
        {
            List<Superhero> superheroes = new List<Superhero>();
            superheroes = db.Superheroes.ToList();
            return View(superheroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Superheroes, "ID", "SuperheroName"); // test
            return View();
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                db.Superheroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                db.Superheroes.Remove(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
