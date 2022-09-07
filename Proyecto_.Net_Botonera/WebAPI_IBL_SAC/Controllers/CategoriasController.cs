using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_IBL_SAC.Models;

namespace WebAPI_IBL_SAC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly APP_IBL_SACContext _context;

        public CategoriasController(APP_IBL_SACContext context)
        {
            _context = context;
            
        }

        // GET: api/Categorias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoria(String searchString)
        {
            var usuarios = from s in _context.Categoria select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                usuarios = usuarios.Where(s => s.Descripcion.Contains(searchString) || s.IdCategoria.ToString().Contains(searchString));

                
                
            }
            return await usuarios.ToListAsync();
        }

        
        // GET: api/Categorias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Categoria>> GetCategoria( int id)
        {
            var categoria = await _context.Categoria.FindAsync(id);

            if (categoria == null)
            {
                return NotFound();
            }

            return Ok(categoria);
        }

        // PUT: api/Categorias/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut]
        public async Task<IActionResult> PutCategoria([FromBody] Categoria pCat)
        {
            if (pCat == null) return BadRequest();
            //Buscando el registro de categoria
            Categoria Catbd = _context.Categoria.FirstOrDefault(x => x.IdCategoria == pCat.IdCategoria);

            if (Catbd == null) //no existe
            {
                return NotFound();
            }

            //Actualizando campos
            Catbd.Activo = pCat.Activo;
            Catbd.Descripcion = pCat.Descripcion;
            Catbd.IdCategoria = pCat.IdCategoria;
            Catbd.Producto = pCat.Producto;
            Catbd.FechaRegistro = pCat.FechaRegistro;
            //Indicando al modelo que el registro tiene modificaciones
            _context.Entry(Catbd).State = EntityState.Modified;
            await _context.SaveChangesAsync(); //grabando cambios
            return Ok(pCat);
        }

        // POST: api/Categorias
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Categoria>> PostCategoria([FromBody] Categoria categoria)
        {
            _context.Categoria.Add(categoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCategoria", new { id = categoria.IdCategoria }, categoria);
        }

        // DELETE: api/Categorias/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Categoria>> DeleteCategoria(int id)
        {
            var categoria = await _context.Categoria.FindAsync(id);
            if (categoria == null)
            {
                return NotFound();
            }

            _context.Categoria.Remove(categoria);
            await _context.SaveChangesAsync();

            return categoria;
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(e => e.IdCategoria == id);
        }
    }
}
