using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IBL_SAC.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Permisos = new HashSet<Permisos>();
            Usuario = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string Descripcion { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual ICollection<Permisos> Permisos { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
