using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using WebAPI_IBL_SAC.Models;
using WebAPI_IBL_SAC.ViewModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_IBL_SAC.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly APP_IBL_SACContext _context;

        public ProductosController(APP_IBL_SACContext context)
        {
            _context = context;

        }
        // GET: api/<ProductosController>
        [HttpGet]
        public ActionResult<IEnumerable<VMProducto>> Get()
        {
            var lst = (from p in _context.Producto
                       where p.Activo == true
                       select new VMProducto
                       {
                           Activo = p.Activo,
                           Descripcion = p.Descripcion,
                           Nombre = p.Nombre,
                           IdCategoria = p.IdCategoria,
                           IdProducto=p.IdProducto,
                           ImagenUrl=p.ImagenUrl,
                           PrecioUnidadCompra=p.PrecioUnidadCompra,
                           PrecioUnidadVenta=p.PrecioUnidadVenta,
                           Stock=p.Stock,
                           Ganancia=p.PrecioUnidadVenta-p.PrecioUnidadCompra,
                           FechaRegistro=p.FechaRegistro,
                           GananciaTotal= (p.PrecioUnidadVenta - p.PrecioUnidadCompra)*p.Stock
                       }).ToList();

            return Ok(lst);
        }

        // GET api/<ProductosController>/5

        [HttpGet("{id}")]
        public ActionResult<VMProducto> GetProducto(int id)
        {
            var objBd = _context.Producto.FirstOrDefault(x => x.IdProducto == id);
            if (objBd != null)
            {
                VMProducto cat = new VMProducto()
                {
                    Nombre = objBd.Nombre,
                    IdCategoria = objBd.IdCategoria,
                    Descripcion = objBd.Descripcion,
                    FechaRegistro = objBd.FechaRegistro,
                    ImagenUrl = objBd.ImagenUrl,
                    PrecioUnidadCompra = objBd.PrecioUnidadCompra,
                    PrecioUnidadVenta = objBd.PrecioUnidadVenta,
                    Activo = objBd.Activo,
                    IdProducto = objBd.IdProducto,
                    Stock = objBd.Stock,

                };
                return Ok(cat);
            }

            return NotFound();
        }


        // POST api/<CategoriasController>
        [HttpPost]
        public async Task<ActionResult<VMProducto>> PostProducto([FromBody] VMProducto pPro)
        {
            Producto Probd = new Producto()
            {
                Nombre = pPro.Nombre,
                IdCategoria = pPro.IdCategoria,
                Descripcion = pPro.Descripcion,
                ImagenUrl = pPro.ImagenUrl,
                PrecioUnidadCompra = pPro.PrecioUnidadCompra,
                PrecioUnidadVenta = pPro.PrecioUnidadVenta,
                Stock = pPro.Stock,
            };

            if (ModelState.IsValid)
            {
                _context.Producto.Add(Probd);
                await _context.SaveChangesAsync();

                pPro.IdCategoria = Probd.IdCategoria;

                return Ok(pPro);
            }
            return BadRequest(ModelState);
        }


        // PUT api/<CategoriasController>/5
        [HttpPut]
        public async Task<IActionResult> PutProducto([FromBody] VMProducto pPro)
        {

            if (pPro == null) return BadRequest();
            //Buscando el registro de categoria
            Producto Probd = _context.Producto.FirstOrDefault(x => x.IdProducto == pPro.IdProducto);

            if (Probd == null) //no existe
            {
                return NotFound();
            }

            //Actualizando campos
            Probd.Nombre = pPro.Nombre;
            Probd.IdCategoria = pPro.IdCategoria;
            Probd.Descripcion = pPro.Descripcion;
            Probd.FechaRegistro = pPro.FechaRegistro;
            Probd.ImagenUrl = pPro.ImagenUrl;
            Probd.PrecioUnidadCompra = pPro.PrecioUnidadCompra;
            Probd.PrecioUnidadVenta = pPro.PrecioUnidadVenta;
            Probd.Activo = pPro.Activo;
            Probd.IdProducto = pPro.IdProducto;
            Probd.Stock = pPro.Stock;
            //Indicando al modelo que el registro tiene modificaciones
            _context.Entry(Probd).State = EntityState.Modified;
            await _context.SaveChangesAsync(); //grabando cambios
            return Ok(pPro);

        }


        // DELETE api/<CategoriasController>/5

        [HttpDelete("{id}")]
        public async Task<ActionResult<Producto>> DeleteProducto(int id)
        {
            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();

            return producto;
        }

        private bool CategoriaExists(int id)
        {
            return _context.Producto.Any(e => e.IdProducto == id);
        }
    }
}