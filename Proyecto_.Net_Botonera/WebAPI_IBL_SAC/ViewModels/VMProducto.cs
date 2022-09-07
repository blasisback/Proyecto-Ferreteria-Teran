using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_IBL_SAC.ViewModels
{
    public class VMProducto
    {
        public int IdProducto { get; set; }
        public string ImagenUrl { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? IdCategoria { get; set; }
        public decimal? PrecioUnidadCompra { get; set; }
        public decimal? PrecioUnidadVenta { get; set; }
        public long? Stock { get; set; }
        public bool? Activo { get; set; }

        public DateTime? FechaRegistro { get; set; }
        public decimal? Ganancia { get; set; }

        public decimal? GananciaTotal { get; set; }
    }
}
