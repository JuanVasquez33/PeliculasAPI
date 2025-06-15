using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class ActorCreacionDTO
    {
        [Required]
        [StringLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public required string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public IFormFile? Foto { get; set; }
    }
}
