using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int RolId { get; set; }
        public string Password { get; set; }
        public bool Estatus { get; set; }
        public int? UsuarioPadreId { get; set; }

        [ForeignKey("RolId")]
        public virtual Roles Roles { get; set; }

        public Usuarios()
        {
            Nombre = "";
            Email = "";
            Password = "";
            Roles = new Roles();
            Estatus = false;
        }
    }
}
