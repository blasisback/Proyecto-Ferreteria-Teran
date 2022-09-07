using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebAPI_IBL_SAC.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Carrito = new HashSet<Carrito>();
            DetalleVenta = new HashSet<DetalleVenta>();
            Kardex = new HashSet<Kardex>();
        }

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

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<Carrito> Carrito { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual ICollection<Kardex> Kardex { get; set; }
    }
}
