using Superheroes;
using Superheroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Superheroes.Controllers
{
    public class SuperheroesController : Controller
    {
        
        // GET: Superheroes
        public ActionResult Index()
        {
            Models.ApplicationDbContext dbContext = new Models.ApplicationDbContext();
            List<Models.Superhero> ListOfSuperheroes = dbContext.Superheroes.ToList();
            return View(ListOfSuperheroes);
        }

        // GET: Superheroes/Details/5
        public ActionResult Details(int id)
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
                Models.ApplicationDbContext dbContext = new Models.ApplicationDbContext();
                dbContext.Superheroes.Add(superhero);
                dbContext.SaveChanges();
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
            return View();
        }

        // POST: Superheroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Superheroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Superheroes/Delete/5
        [HttpPost]
        public ActionResult Delete(Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                Models.ApplicationDbContext dbContext = new Models.ApplicationDbContext();
                dbContext.Superheroes.Add(superhero);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
