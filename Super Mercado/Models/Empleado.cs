using System.ComponentModel.DataAnnotations;

namespace Super_Mercado.Models
{
    public class Empleado
    {
        public long Id { get; set; }

        [Required]
        public int Documento { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }
    }
}
