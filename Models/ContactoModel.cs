using System.ComponentModel.DataAnnotations;

namespace CRUDCORE.Models
{
    public class ContactoModel
    {

        public int IdContacto { get; set; }


        [Required(ErrorMessage = "El campo de Nombre es obligatorio")]
        public string? Nombre { get; set; }

        [Required (ErrorMessage = "El campo de Telefono es obligatorio")]
        public string? Telefono { get; set; }
        
        [Required(ErrorMessage = "El campo de Correo es obligatorio")]
        public string? Correo { get; set;}
    }
}
