﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppProjeto01.Context;
using WebAppProjeto01.Models;

namespace WebAppProjeto01.Controllers
{
    public class HomeController : Controller
    {
        private readonly EFContext context = new EFContext();

        // GET: Home
        public ActionResult Index()
        {
            var categorias = context.Categorias;
            var fabricantes = context.Fabricantes;
            var home = new Home() { Fabricantes = fabricantes, Categorias = categorias };
            return View(home);
        }
    }
}