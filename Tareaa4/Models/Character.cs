using System.ComponentModel.DataAnnotations;
using Tareaa4.Models;

namespace Tareaa4.Models
{
    public class Character
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Apodo es obligatorio")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "El campo Raza es obligatorio")]
        public string Race { get; set; }

        [Required(ErrorMessage = "El campo URL de la Foto es obligatorio")]
        [Url(ErrorMessage = "La URL debe ser válida")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "El campo Edad es obligatorio")]
        [Range(0, 1000, ErrorMessage = "La edad debe estar entre 0 y 1000")]
        public int Age { get; set; }

        [Required(ErrorMessage = "El campo Poder Característico es obligatorio")]
        public string Power { get; set; }

        [Required(ErrorMessage = "Debe seleccionar la serie/película/libro")]
        public int MediaItemId { get; set; } // Para asociar al medio (serie, película o libro)

        public MediaItem MediaItem { get; set; } // Relación con MediaItem
    }
}
