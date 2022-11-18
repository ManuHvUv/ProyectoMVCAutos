using Microsoft.AspNetCore.Mvc;

namespace ProyectoCurso.Models
{
    public class Linea
    {
        [HiddenInput]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int MarcaId { get; set; }
        public Marca? Marca { get; set; }
    }
}
