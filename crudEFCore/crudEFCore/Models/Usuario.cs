using System.ComponentModel.DataAnnotations;

namespace crudEFCore.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; } 
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Celular { get; set; }
        [Required(ErrorMessage = "Campo obligatorio")]
        public string Email { get; set; }
    }
}
