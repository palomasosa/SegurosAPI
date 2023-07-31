using Microsoft.EntityFrameworkCore;

namespace SegurosAPI.Models
{
    public class DBContext: DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cobertura> Coberturas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<MetodoPago> MetodoPagos { get; set; }
        public DbSet<Pagos> Pagos { get; set; }
        public DbSet<Poliza> Polizas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach ( /// Desactiva la eliminacion en cascada de todas las relaciones
                var relationship in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
    }
}
