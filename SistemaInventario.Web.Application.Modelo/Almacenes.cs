using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class Almacenes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int EmpresaId { get; set; }
        public bool Estatus { get; set; }
        public DateTime Fecha { get; set; }

        public Almacenes()
        {
            Nombre = "";
            Direccion = "";
            Estatus = false;
            Fecha = DateTime.Now;
        }
    }
}
