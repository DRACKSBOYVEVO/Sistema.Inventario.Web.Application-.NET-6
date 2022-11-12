using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class Roles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
        public DateTime Fecha { get; set; }
        public int UsuarioId { get; set; }

        public Roles()
        {
            Rol = "";
            Activo = false;
            Fecha = DateTime.Now;
        }
    }
}
