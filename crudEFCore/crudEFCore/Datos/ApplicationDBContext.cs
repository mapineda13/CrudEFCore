using crudEFCore.Models;
using Microsoft.EntityFrameworkCore;
namespace crudEFCore.Datos
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        //Agregando el modelo usuario
        public DbSet<Usuario> Usuario { get; set; }
    }
}
