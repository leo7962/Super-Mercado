using System.ComponentModel.DataAnnotations;

namespace Super_Mercado.Models
{
    public class Detalle_Pedido
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public long Id_Pedido { get; set; }

        [Required]
        public long Id_Producto { get; set; }
    }
}
