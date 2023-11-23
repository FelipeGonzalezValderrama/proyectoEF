
using System.ComponentModel.DataAnnotations;

namespace projectoef.Models
{
    public class Tarea
    {
        public Guid TareaId { set; get; }
        public Guid CategoriaId { set; get; }
        public required string Titulo { set; get; }
        public required string Descripcion { set; get; }
        [EnumDataType(typeof(Prioridad))]
        public Prioridad PrioridadTarea { set; get; }
        public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
        public string? Resumen { set; get; }

        // Nueva propiedad de navegación

        public virtual Categoria? Categoria { set; get; }
    }

    public enum Prioridad
    {
        Baja,
        Media,
        Alta
    }
}