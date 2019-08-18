using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Super_Mercado.Models
{
    public class Detalle_Pedido
{
        public long Id { get; set; }

        [Required]
        public long Id_Pedido { get; set; }

        [Required]
        public long Id_Producto { get; set; }
}
}
