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
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var superheroes = db.Superheroes.SingleOrDefault(s => s.HeroId == id);
            if (superheroes == null )
            {
                return HttpNotFound();
            }
            return View(superheroes);
            //return View(db.Superheroes.Where(d => d.HeroId == id).SingleOrDefault());
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                Superhero thisSuperhero = db.Superheroes.Find(id);
                
                thisSuperhero.HeroName = superhero.HeroName;
                thisSuperhero.AlterEgo = superhero.AlterEgo;
                thisSuperhero.PrimaryAbility = superhero.PrimaryAbility;
                thisSuperhero.SecondaryAbility = superhero.SecondaryAbility;
                thisSuperhero.CatchPhrase = superhero.CatchPhrase;

                db.SaveChanges();

                return RedirectToAction("Index", "Superheroes");
            }
            catch
            {
                return View(superhero);
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
            //try
            //{
                // TODO: Add delete logic here
            var superheroes = db.Superheroes.SingleOrDefault(s => s.HeroId == id);
            db.Superheroes.Remove(db.Superheroes.Find(id));
            db.SaveChanges();

            return View("Index", superheroes);
                //return RedirectToAction("Index", superhero);
            //}
            //catch
            //{
            //    return View();
            //}
        }
    }
}
