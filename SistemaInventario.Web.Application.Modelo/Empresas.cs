using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class Empresas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Estatus { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }

        public Empresas()
        {
            Nombre = "";
            Fecha = DateTime.Now;
            Estatus = false;
        }
    }
}
