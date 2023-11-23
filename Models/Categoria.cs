

using System.Text.Json.Serialization;

namespace projectoef.Models
{
    public class Categoria
    {
        public Guid CategoriaId { get; set; }
        public required string Nombre { get; set; }
        public required string Descripcion { set; get; }
        public int Peso { get; set; }

        // Nueva propiedad de navegación
        [JsonIgnore]
        public virtual ICollection<Tarea>? Tareas { get; set; }
    }
}