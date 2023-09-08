using PeliculasAPI.Validaciones;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.Entidades
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50)]
        [PrimeraLetraMayuscula]

        public string Nombre { get; set; }

    }
}
