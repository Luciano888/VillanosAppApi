using Microsoft.EntityFrameworkCore;
using Model;

namespace Persistence
{
    public class VillanoDbContext : DbContext
    {
        // public DbSet<Student> Student { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Ciudadano> Ciudadanos { get; set; }
        public DbSet<DetalleCiudadanoTarea> DetalleCiudadanoTareas { get; set; }
        public VillanoDbContext(DbContextOptions<VillanoDbContext> options)
            : base(options)
        { }
    }
}
