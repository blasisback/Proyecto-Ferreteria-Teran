using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp_IBL_SAC.ViewModels
{
    public class VMCategoria
    {
        public int IdCategoria { get; set; }
        [Required(ErrorMessage = "Se necesita una descripcion para la categoria")]
        public string Descripcion { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
