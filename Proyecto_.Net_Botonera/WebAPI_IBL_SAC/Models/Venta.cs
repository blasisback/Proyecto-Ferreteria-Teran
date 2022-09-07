using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IBL_SAC.Models
{
    public partial class Venta
    {
        public Venta()
        {
            DetalleVenta = new HashSet<DetalleVenta>();
            Kardex = new HashSet<Kardex>();
        }

        public int IdVenta { get; set; }
        public string Codigo { get; set; }
        public int? ValorCodigo { get; set; }
        public int? IdUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public int? CantidadProducto { get; set; }
        public decimal? TotalCosto { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual ICollection<Kardex> Kardex { get; set; }
    }
}
