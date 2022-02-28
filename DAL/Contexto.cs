using Microsoft.EntityFrameworkCore;
using ExamenBlazor.Entidades;

public class Contexto:DbContext{
    public DbSet<Producto> Producto {get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
         optionsBuilder.UseSqlite(@"Data Source=Data\Producto.db");
    }
}