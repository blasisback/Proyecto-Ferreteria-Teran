using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp_BotoneraLozanoSAC.Models;

namespace WebApp_BotoneraLozanoSAC.Controllers
{
    public class KardexesController : Controller
    {
        private readonly APP_IBL_SACContext _context;

        public KardexesController(APP_IBL_SACContext context)
        {
            _context = context;
        }

        // GET: Kardexes
        public async Task<IActionResult> Index(DateTime date,int? EA)
        {

            DateTime dat = new DateTime(2009, 8, 1);
            var kardex = from s in _context.Kardex.Include(x => x.IdProductoNavigation).Include(x=>x.DocumentoNavigation) select s;
            var v = date.Date;
            var vadd = date.Date.AddDays(1);
           
            if (date > dat)
            {


                kardex= kardex.Where(x => x.FechaRegistro >= v && x.FechaRegistro <= vadd);
            };
           
            if (EA==1)
            {
                kardex = kardex.Where(x=>x.EntradaCantidad!=0);
            }
            if (EA==0)
            {
                kardex = kardex.Where(x => x.SalidaCantidad!= 0);
            }
            ViewBag.sumKardexSalida = kardex.Sum(x=>x.SalidaCantidad);
            ViewBag.sumKardexEntrada = kardex.Sum(x=>x.EntradaCantidad);

            return View(await kardex.OrderByDescending(x=>x.FechaRegistro).ToListAsync());
        }

        // GET: Kardexes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kardex = await _context.Kardex
                .Include(k => k.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.IdKardex == id);
            if (kardex == null)
            {
                return NotFound();
            }

            return View(kardex);
        }

        // GET: Kardexes/Create
        public IActionResult Create()
        {
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "Descripcion");
            return View();
        }

        // POST: Kardexes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdKardex,FechaRegistro,SalidaCantidad,EntradaCantidad,SaldoCantidad,IdProducto,PrecioUnitarioVenta,PrecioUnitarioCompra,Total")] Kardex kardex)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kardex);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "Descripcion", kardex.IdProducto);
            return View(kardex);
        }

        // GET: Kardexes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kardex = await _context.Kardex.FindAsync(id);
            if (kardex == null)
            {
                return NotFound();
            }
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "Descripcion", kardex.IdProducto);
            return View(kardex);
        }

        // POST: Kardexes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdKardex,FechaRegistro,SalidaCantidad,EntradaCantidad,SaldoCantidad,IdProducto,PrecioUnitarioVenta,PrecioUnitarioCompra,Total")] Kardex kardex)
        {
            if (id != kardex.IdKardex)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kardex);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KardexExists(kardex.IdKardex))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "Descripcion", kardex.IdProducto);
            return View(kardex);
        }

        // GET: Kardexes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kardex = await _context.Kardex
                .Include(k => k.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.IdKardex == id);
            if (kardex == null)
            {
                return NotFound();
            }

            return View(kardex);
        }

        // POST: Kardexes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kardex = await _context.Kardex.FindAsync(id);
            _context.Kardex.Remove(kardex);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KardexExists(int id)
        {
            return _context.Kardex.Any(e => e.IdKardex == id);
        }
    }
}
