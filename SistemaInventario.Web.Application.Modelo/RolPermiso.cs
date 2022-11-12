using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class RolPermisos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Accion { get; set; }
        public int RolId { get; set; }
        public bool Activo { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("RolId")]
        public virtual Roles Roles { get; set; }

        public RolPermisos()
        {
            Accion = "";
            Fecha = DateTime.Now;
            Roles = new Roles();
            Activo = false;
        }
    }
}
