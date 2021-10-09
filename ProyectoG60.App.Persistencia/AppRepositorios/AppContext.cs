//directivas
using Microsoft.EntityFrameworkCore;
using ProyectoG60.App.Dominio;

namespace ProyectoG60.App.Persistencia
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
                .UseSqlServer("Server=localhost; Database=Desault; user id=sa; password=12345; Initial Catalog = ProyectoG60");
               //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =ProyectoG60");
            }
        }        
    }
}