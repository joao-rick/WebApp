using Modelo.Cadastros;
using System;
using Modelo.Tabelas;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Persistencia.Contexts;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Persistencia.Contexts
{
    public class EFContext : DbContext { 
    public EFContext() : base("WebAppDB")
    {
        Database.SetInitializer<EFContext>(
        new DropCreateDatabaseIfModelChanges<EFContext>());
    }
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Fabricante> Fabricantes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
    }
}