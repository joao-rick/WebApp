using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Net;
using System.Web.Mvc;
using WebApp.Context;
using WebApp.Models;
using WebApp.Context;
using System.Data.Entity;

namespace WebApp.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly EFContext context = new EFContext();
        // GET: Categorias
        public ActionResult Index()
        {
<<<<<<< HEAD
            return View(context.Categorias.OrderBy(f => f.Nome));
=======
            return View(context.Categorias.OrderBy(c => c.Nome));
>>>>>>> 9d93c6f57bb7c68c8570ddec69738b81bfb437eb
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria Categoria)
        {
<<<<<<< HEAD
            if (ModelState.IsValid)
            {
                context.Categorias.Add(Categoria);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
=======
            if (!ModelState.IsValid)
            {
                return View();
            }

            context.Categorias.Add(categoria);
            context.SaveChanges();
            return RedirectToAction("Index");
>>>>>>> 9d93c6f57bb7c68c8570ddec69738b81bfb437eb
        }

        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
<<<<<<< HEAD
            Categoria Categoria = context.Categorias.Find(id);
            if (Categoria == null)
            {
                return HttpNotFound();
            }
            return View(Categoria);
=======

            Categoria c = context.Categorias.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }

            return View(c);
>>>>>>> 9d93c6f57bb7c68c8570ddec69738b81bfb437eb
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categoria Categoria)
        {
<<<<<<< HEAD
            if (ModelState.IsValid)
            {
                context.Entry(Categoria).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Categoria);
=======
            if (!ModelState.IsValid)
            {
                return View(categoria);
            }

            context.Entry(categoria).State = EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("Index");
>>>>>>> 9d93c6f57bb7c68c8570ddec69738b81bfb437eb
        }

        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
<<<<<<< HEAD
            Categoria Categoria = context.Categorias.Find(id);
            if (Categoria == null)
            {
                return HttpNotFound();
            }
            return View(Categoria);
=======
            Categoria c = context.Categorias.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
>>>>>>> 9d93c6f57bb7c68c8570ddec69738b81bfb437eb
        }

        public ActionResult Delete(long? id)
        {
<<<<<<< HEAD
            Categoria Categoria = context.Categorias.Find(id);
            context.Categorias.Remove(Categoria);
            context.SaveChanges();
            TempData["Message"] = "Categoria " + Categoria.Nome.ToUpper() + " foi removido";
            return RedirectToAction("Index");
=======
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoria c = context.Categorias.Find(id);
            if (c == null)
            {
                return HttpNotFound();
            }
            return View(c);
>>>>>>> 9d93c6f57bb7c68c8570ddec69738b81bfb437eb
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
<<<<<<< HEAD
            Categoria Categoria = context.Categorias.Find(id);
            context.Categorias.Remove(Categoria);
            context.SaveChanges();
            TempData["Message"] = "Categoria " + Categoria.Nome.ToUpper() + " foi removido";
=======
            Categoria c= context.Categorias.Find(id);
            context.Categorias.Remove(c);
            context.SaveChanges();
            TempData["message"] = $"Categoria {c.Nome} foi removida com sucesso";
>>>>>>> 9d93c6f57bb7c68c8570ddec69738b81bfb437eb
            return RedirectToAction("Index");
        }
    }
}