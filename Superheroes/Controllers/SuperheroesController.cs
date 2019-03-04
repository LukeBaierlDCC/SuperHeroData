using Superheroes;
using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class SuperheroesController : Controller
    {
        ApplicationDbContext db;
        public SuperheroesController()
        {
            db = new ApplicationDbContext();
        }
        
        // GET: Superheroes
        public ActionResult Index()
        {
            Models.ApplicationDbContext db = new Models.ApplicationDbContext();
            List<Models.Superhero> ListOfSuperheroes = db.Superheroes.ToList();
            return View(ListOfSuperheroes);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id, Superhero superhero)
        {
            return View();
        }

        // GET: Superheroes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Superheroes/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                Models.ApplicationDbContext db = new Models.ApplicationDbContext();
                db.Superheroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Edit/5
        public ActionResult Edit(int id)
        {
            //if (id == null)
            //{
            //    return new ();
            //}
            //object db = null;
            //Superhero superheroDetail = db.SuperheroDetails.Find(id);
            //if (id == null)
            //{
            //    return HttpNotFound();
            //}
            return View();
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                //db.Entry(superheroDetail).State = EntityState.Modified;
                //db.SaveChanges();
                //var Superhero
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View(db.Superheroes.Find(id));
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                db.Superheroes.Remove(db.Superheroes.Find(id));
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
