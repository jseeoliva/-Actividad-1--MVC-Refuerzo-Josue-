using System.ComponentModel.DataAnnotations;

namespace MVC_Refuerzo.Models
{
    public class Producto
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio"), Display(Name = "Nombre Del Producto")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion es obligatoria"), Display(Name = "Descripcion Del Producto")]
        public string Descripcion { get; set; }

    }
}
