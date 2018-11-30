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
            List<Superhero> superheroesList = new List<Superhero>();
            superheroesList = db.Superheroes.ToList();
            return View(superheroesList);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Superhero superhero = db.Superheroes.Find(id);
            if (superhero == null)
            {
                return HttpNotFound();
            }
            return View(superhero);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Superheroes, "ID", "SuperheroName");
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
