using Microsoft.EntityFrameworkCore;
namespace Convivencia.Models{
    public class DatabaseContext:DbContext{
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options){

        }
        public DbSet<Estudiante> Estudiante{get;set;}
    }
}