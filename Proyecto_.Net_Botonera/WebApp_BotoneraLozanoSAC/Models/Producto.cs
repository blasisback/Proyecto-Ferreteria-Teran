using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApp_BotoneraLozanoSAC.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Carrito = new HashSet<Carrito>();
            DetalleVenta = new HashSet<DetalleVenta>();
        }

        public int IdProducto { get; set; }
        [Required(ErrorMessage = "La imagen es obligatoria")]
        [DataType(DataType.ImageUrl)]
        public string ImagenUrl { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [RegularExpression("[a-zA-Z ]{2,100}", ErrorMessage = "Solo admite letras entre 2 y 100")]

        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatorio")]
        public string Descripcion { get; set; }

        public int? IdCategoria { get; set; }
        [Required(ErrorMessage = "El Precio de Compra es Obligatorio")]
        [Range(1, 999999999, ErrorMessage = "El valor debe estar entre 1 y 999999999")]

        public decimal? PrecioUnidadCompra { get; set; }
        [Required(ErrorMessage = "El Precio de Venta es Obligatorio")]
        [Range(1, 999999999, ErrorMessage = "El valor debe estar entre 1 y 999999999")]
        public decimal? PrecioUnidadVenta { get; set; }
        [Required(ErrorMessage = "El Stock es Obligatorio")]
        [Range(1, 999999999, ErrorMessage = "El valor debe estar entre 1 y 100000")]
        public long? Stock { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<Carrito> Carrito { get; set; }
        public virtual ICollection<DetalleVenta> DetalleVenta { get; set; }
        public virtual ICollection<Kardex> Kardex { get; set; }

    }
}
