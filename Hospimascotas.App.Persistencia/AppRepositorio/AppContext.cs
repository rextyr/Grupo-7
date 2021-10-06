using Microsoft.EntityFrameworkCore;
using Hospimascotas.App.Dominio;
using Hospimascotas.App.Persistencia;

namespace Hospimascotas.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<MascotaEnferma> MascotasEnfermas { get; set; }
        public DbSet<Historia> Historias { get; set; }
        public DbSet<Persona>  Personas { get; set; }
        public DbSet<MedicoVeterinario> MedicosVeterianarios { get; set; }
        public DbSet<AuxiliarVeterinario> AuxiliaresVeterinarios { get; set; }
        public DbSet<SugerenciaCuidado> SugerenciasCuidado { get; set; }
        public DbSet<SignosVitales> SignosVitales { get; set; }
        public DbSet<Dueño> Dueños { get; set; }
        
        
        
        
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
         if (!optionsBuilder.IsConfigured)
         {
             optionsBuilder
             .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog  = HospiMascotas.Data");
         }   
        }
    }
}