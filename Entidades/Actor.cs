using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Entidades
{
    public class Actor
    {
        public int Id { get; set; }
        [Required]
        [StringLength(150, ErrorMessage = "El campo {0} no puede tener más de {1} caracteres")]
        public required string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        [Unicode(false)]
        public string? Foto { get; set; }
    }
}
