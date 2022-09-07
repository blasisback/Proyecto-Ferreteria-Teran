using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp_BotoneraLozanoSAC.Models
{
    public partial class Kardex
    {
        public int IdKardex { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? Documento { get; set; }
        public int? SalidaCantidad { get; set; }
        public int? EntradaCantidad { get; set; }
        public int? SaldoCantidad { get; set; }
        public int IdProducto { get; set; }
        public decimal? PrecioUnitarioVenta { get; set; }
        public decimal? PrecioUnitarioCompra { get; set; }
        public decimal? Total { get; set; }

        public virtual Producto IdProductoNavigation { get; set; }
        public virtual Venta DocumentoNavigation { get; set; }
    }
}
