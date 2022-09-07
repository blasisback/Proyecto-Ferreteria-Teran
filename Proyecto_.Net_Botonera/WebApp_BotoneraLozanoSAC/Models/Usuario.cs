using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp_BotoneraLozanoSAC.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Venta = new HashSet<Venta>();
        }

        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression("[a-zA-Z ]{2,20}", ErrorMessage = "Solo admite letras entre 2 y 20")]

        public string Nombres { get; set; }
        [Required(ErrorMessage = "El apellido es obligatorio")]
        [RegularExpression("[a-zA-Z ]{2,20}", ErrorMessage = "Solo admite letras entre 2 y 20")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "No tiene el formato de e-mail")]
        public string Correo { get; set; }
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        
        public string Clave { get; set; }
        public int? IdRol { get; set; }
        public bool? Activo { get; set; }

        public string TipoDocumento { get; set; }
        [Required(ErrorMessage = "El número de documento es necesario")]
        public string NumeroDocumento { get; set; }
        [Required(ErrorMessage = "La dirección es necesaria")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El teléfono es necesario")]
        [Range(1,999999999,ErrorMessage= "El valor debe estar entre 1 y 999999999")]
        public string Telefono { get; set; }
       
        public DateTime? FechaRegistro { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual ICollection<Venta> Venta { get; set; }
    }
}
