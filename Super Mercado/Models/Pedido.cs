using System.ComponentModel.DataAnnotations;

namespace Super_Mercado.Models
{
    public class Pedido
    {
        public long Id { get; set; }

        [Required]
        public long Id_Sucursal { get; set; }

        [Required]
        public long Id_Empleado { get; set; }

        [Required]
        public long Id_Cliente { get; set; }

        [Required]
        public long Id_Detalle { get; set; }

    }
}
