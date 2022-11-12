using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class Compra_Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Total { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }
        public int CompraId { get; set; }

        public Compra_Productos()
        {
            Fecha = DateTime.Now;
            Cantidad = 0;
            Total = 0;
        }
    }
}
