using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp_BotoneraLozanoSAC.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Permisos = new HashSet<Permisos>();
            Usuario = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        [Required(ErrorMessage = "Se necesita una descripcion para la categoria")]
        [RegularExpression("[a-zA-Z ]{2,20}", ErrorMessage = "Solo admite letras entre 2 y 20")]
        public string Descripcion { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Permisos> Permisos { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
