using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class Compras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProveedorId { get; set; }
        public DateTime? Fecha { get; set; }
        public string CodigoFactura { get; set; }
        public decimal Total { get; set; }
        public bool Estatus { get; set; }
        public int EmpresaId { get; set; }
        public int UsuarioId { get; set; }

        public Compras()
        {
            Fecha = DateTime.Now;
            CodigoFactura = "";
            Total = 0;
            Estatus = false;
        }
    }
}
