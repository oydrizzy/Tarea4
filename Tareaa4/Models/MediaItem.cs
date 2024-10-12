using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tareaa4.Models;

namespace Tareaa4.Models
{
    public class MediaItem
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo País es obligatorio")]
        public string Country { get; set; }

        [Required(ErrorMessage = "El campo Idioma es obligatorio")]
        public string Language { get; set; }

        [Required(ErrorMessage = "El campo URL de la Foto es obligatorio")]
        [Url(ErrorMessage = "La URL debe ser válida")]
        public string PhotoUrl { get; set; }

        [Required(ErrorMessage = "El campo Resumen es obligatorio")]
        public string Summary { get; set; }

        public List<Character> Characters { get; set; }  // Relación con personajes
    }
}
