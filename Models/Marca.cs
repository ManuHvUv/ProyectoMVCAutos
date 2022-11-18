using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ProyectoCurso.Models
{
    public class Marca
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Escriba el nombre de la marca")]
        [MinLength(1, ErrorMessage = "El nombre debe ser minimo de 1 caracter")]
        [MaxLength(200, ErrorMessage = "El nombre debe ser maximo de 200 caracteres")]
        public string Nombre { get; set; } = string.Empty;
        [Required(ErrorMessage = "Asigne el logo de la marca")]
        [MaxLength(1, ErrorMessage = "El logo debe ser solo 1 caracter")]
        public string Logo { get; set; } = string.Empty;
    }
}
