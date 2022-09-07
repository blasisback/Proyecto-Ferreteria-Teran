using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApp_BotoneraLozanoSAC.ViewModels
{
    public class UsuarioLogin
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "El usuario es necesario")]
        public string correo{ get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "La contraseña es necesaria")]
        public string Contrasena { get; set; }

    }
}
