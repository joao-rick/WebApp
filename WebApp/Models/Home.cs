﻿using Modelo.Cadastros;
using Modelo.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Home
    {
        public IEnumerable<Fabricante> Fabricantes { get; set; }
        public IEnumerable<Categoria> Categorias { get; set; }
    }
}