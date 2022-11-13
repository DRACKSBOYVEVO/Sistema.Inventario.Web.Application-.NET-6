using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.Web.Application.Modelo
{
    public class Contactos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string? Telefono { get; set; }
        public string? Extension { get; set; }
        public string? Email { get; set; }
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Estatus { get; set; }
        public int EmpresaId { get; set; }
        public int UsuarioId { get; set; }

        public Contactos()
        {
            Nombre = "";
            Direccion = "";
            Telefono = "";
            Extension = "";
            Email = "";
            Fecha = DateTime.Now;
            Tipo = "";
            Estatus = "";
        }
    }
}
