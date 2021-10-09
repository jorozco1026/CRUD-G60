//directivas
using Microsoft.EntityFrameworkCore;
using ProyectoG60.App.Dominio.Entidades;

namespace ProyectoG60.App.Persistencia.AppRepositorios
{
    public class AppContext  : DbContext
    {
        public DbSet<Formador> Formadores { get; set; }
  
        //crear el deContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =ProyectoG60");
            }
        }        
    }
}