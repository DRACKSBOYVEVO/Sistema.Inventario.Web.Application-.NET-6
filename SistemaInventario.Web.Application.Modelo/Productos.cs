using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class Productos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Modelo { get; set; }
        public string Presentacion { get; set; }
        public string Marca { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Stock { get; set; }
        public bool Estatus { get; set; }
        public int EmpresaId { get; set; }
        public int? AlmacenId { get; set; }
        public int UsuarioId { get; set; }

        public Productos()
        {
            Codigo = "";
            Nombre = "";
            Descripcion = "";
            Modelo = "";
            Presentacion = "";
            Marca = "";
            Costo = 0;
            PrecioVenta = 0;
            Stock = 0;
        }
    }
}
