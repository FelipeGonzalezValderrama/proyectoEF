using Microsoft.EntityFrameworkCore;
using projectoef.Models;

namespace projectoef
{
    public class TareasContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tarea> Tareas { get; set; }

        public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Categoria> categoriasInit = new List<Categoria>
            {
                new Categoria
                {
                    CategoriaId = Guid.Parse("6e2aae0d-c8ea-4ebb-a435-a3a6f037b850"),
                    Nombre = "Actividades pendientes",
                    Descripcion = "Actividades Cotidianas",
                    Peso = 20
                },
                new Categoria
                {
                    CategoriaId = Guid.Parse("6e2aae0d-c8ea-4ebb-a435-a3a6f037b860"),
                    Nombre = "Desarrollo Web",
                    Descripcion = "requerimientos Web",
                    Peso = 20
                }
            };

            List<Tarea> tareasInit = new List<Tarea>
            {
                new Tarea
                {
                    TareaId = Guid.Parse("6e2aae0d-c8ea-4ebb-a435-a3a6f037b897"),
                    Titulo = "Tarea 1",
                    Descripcion = "Tarea rapida",
                    PrioridadTarea = Prioridad.Baja,
                    Resumen = "envio de mail respuesta",
                    CategoriaId = Guid.Parse("6e2aae0d-c8ea-4ebb-a435-a3a6f037b850"),

                },
                new Tarea
                {
                    TareaId = Guid.Parse("6e2aae0d-c8ea-4ebb-a435-a3a6f037b898"),
                    Titulo = "Tarea 2",
                    Descripcion = "Tarea Front",
                    PrioridadTarea = Prioridad.Alta,
                    Resumen = "Creacion Btn Login",
                    CategoriaId = Guid.Parse("6e2aae0d-c8ea-4ebb-a435-a3a6f037b860")
                },
                new Tarea
                {
                    TareaId = Guid.Parse("6e2aae0d-c8ea-4ebb-a435-a3a6f037b899"),
                    Titulo = "Tarea 3",
                    Descripcion = "Cotizacion proyecto web",
                    PrioridadTarea = Prioridad.Media,
                    Resumen = "cotizacion",
                    CategoriaId = Guid.Parse("6e2aae0d-c8ea-4ebb-a435-a3a6f037b850"),
                }
            };
            modelBuilder.Entity<Categoria>(categoria =>
            {
                categoria.ToTable("Categoria");
                categoria.HasKey(p => p.CategoriaId);
                categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
                categoria.Property(p => p.Descripcion).HasMaxLength(300);
                categoria.Property(p => p.Peso);
                categoria.HasMany(p => p.Tareas).WithOne(p => p.Categoria).HasForeignKey(p => p.CategoriaId);
                categoria.HasData(categoriasInit);
            });

            modelBuilder.Entity<Tarea>(tarea =>
            {
                tarea.ToTable("Tarea");
                tarea.HasKey(p => p.TareaId);
                tarea.Property(p => p.Titulo).IsRequired().HasMaxLength(200);
                tarea.Property(p => p.Descripcion).IsRequired(false).HasMaxLength(500);
                tarea.Property(p => p.PrioridadTarea).IsRequired();
                tarea.Property(p => p.FechaCreacion).IsRequired();
                tarea.Ignore(p => p.Resumen);
                tarea.HasOne(p => p.Categoria).WithMany(p => p.Tareas).HasForeignKey(p => p.CategoriaId);
                tarea.HasData(tareasInit);
            });
        }
    }
}