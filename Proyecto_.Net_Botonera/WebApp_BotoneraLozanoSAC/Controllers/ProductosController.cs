using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp_BotoneraLozanoSAC.Models;
using System.Net.Http;
using System.Net.Http.Headers;

//Librerias para el fomateo de los Objetos Json
using System.Text;
using Newtonsoft.Json;
namespace WebApp_BotoneraLozanoSAC.Controllers
{
    [Authorize]
    public class ProductosController : Controller
    {

        static List<Categoria> lst = new List<Categoria>();
        private readonly APP_IBL_SACContext _context;
        public string BaseUrl { get; set; }
        public ProductosController(APP_IBL_SACContext context)
        {
            _context = context;
            this.BaseUrl = "https://localhost:44382/Api/Categorias";
        }

        // GET: Productos
        public async Task<IActionResult> Index(string searchString)
        {
            

            HttpClient client = new HttpClient(); // declarando conector

            client.BaseAddress = new Uri(BaseUrl); // Estableciendo URL del servicio
            // Capturando Respuesta HTTP >>>>>      Método Http Get
            HttpResponseMessage resp = await client.GetAsync(""); //

            ViewBag.Producto = 1;
            ViewData["CurrentFilter"] = searchString;
            

            if (resp.IsSuccessStatusCode)
            { // si llamada es correcta
                //Obteniendo el resultado en cadena
                var readtask = resp.Content.ReadAsStringAsync().Result;
                //deserializa   de cadena a objeto
                lst = JsonConvert.DeserializeObject<List<Categoria>>(readtask);
            }



            ViewBag.Producto = 1;
            ViewData["CurrentFilter"] = searchString;
            var productos = from s in _context.Producto.Include(u => u.IdCategoriaNavigation) select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                productos = productos.Where(s => s.IdProducto.ToString().Contains(searchString) || s.Nombre.Contains(searchString));
                var countpro = productos.Count();
                if (countpro == 0)
                {
                    ViewBag.Producto = 0;
                }
            }
            String Prodss = "";
            var prodFalt = from s in _context.Producto select s;
            var p = prodFalt.Where(x => x.Stock <= 10);
            var pa = from s in p select s.Nombre;
            foreach (var Item in pa)
            {
                Prodss += "*PRODUCTO =>>> (" + Item + ")\n";
            }
            var pc = p.Count();
            ViewBag.pc = pc;
            ViewData["a"] = Prodss;
            return View(await productos.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(lst, "IdCategoria", "Descripcion");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdProducto,ImagenUrl,ValorCodigo,Nombre,Descripcion,IdCategoria,Activo,FechaRegistro,PrecioUnidadCompra,PrecioUnidadVenta,Stock")] Producto producto)
        {


            if (ModelState.IsValid)
            {
                if (producto.PrecioUnidadCompra > producto.PrecioUnidadVenta)
                {
                    ViewBag.error = 1;
                    ViewData["IdCategoria"] = new SelectList(lst, "IdCategoria", "Descripcion");
                    return View();
                }
                else
                {
                    _context.Add(producto);
                    await _context.SaveChangesAsync();
                    var var1 = from s in _context.Producto select s;
                    var var2 = var1.OrderByDescending(x => x.IdProducto).First();
                    Kardex kardex = new Kardex()
                    {
                        IdProducto = var2.IdProducto,
                        EntradaCantidad = Convert.ToInt32(var2.Stock),
                        SalidaCantidad = 0,

                        FechaRegistro = var2.FechaRegistro,
                        PrecioUnitarioCompra = var2.PrecioUnidadCompra,
                        PrecioUnitarioVenta = var2.PrecioUnidadVenta,
                        SaldoCantidad = Convert.ToInt32(var2.Stock),
                        Total = Convert.ToInt32(var2.Stock) * var2.PrecioUnidadCompra
                    };
                    _context.Add(kardex);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            ViewData["IdCategoria"] = new SelectList(lst, "IdCategoria", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto.FindAsync(id);
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(lst, "IdCategoria", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProducto,ImagenUrl,ValorCodigo,Nombre,Descripcion,IdCategoria,Activo,FechaRegistro,PrecioUnidadCompra,PrecioUnidadVenta,Stock")] Producto producto)
        {
            if (id != producto.IdProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (producto.PrecioUnidadCompra > producto.PrecioUnidadVenta)
                    {


                        ViewBag.error = 1;
                        ViewData["IdCategoria"] = new SelectList(lst, "IdCategoria", "Descripcion");
                        return View();
                    }
                    else
                    {
                        List<Producto> prod = _context.Producto.AsNoTracking().ToList();
                        var pid = prod.Where(x => x.IdProducto == id).First();


                        _context.Update(producto);
                        var saldo = _context.Producto.Find(id).Stock;
                        if (pid.Stock < producto.Stock)
                        {
                            Kardex kardexE = new Kardex()
                            {
                                IdProducto = producto.IdProducto,
                                SalidaCantidad = 0,
                                EntradaCantidad = Convert.ToInt32(producto.Stock - pid.Stock),
                                PrecioUnitarioCompra = Convert.ToDecimal(producto.PrecioUnidadCompra),
                                PrecioUnitarioVenta = Convert.ToDecimal(producto.PrecioUnidadVenta),
                                SaldoCantidad = Convert.ToInt32(saldo),
                                Total = Convert.ToInt32((producto.Stock - pid.Stock) * producto.PrecioUnidadCompra)
                            };
                            _context.Add(kardexE);

                        }
                        if (pid.Stock > producto.Stock)
                        {
                            
                            Kardex kardexS = new Kardex()
                            {
                                IdProducto = producto.IdProducto,
                                EntradaCantidad=0,
                                SalidaCantidad = Convert.ToInt32(pid.Stock - producto.Stock),
                                PrecioUnitarioCompra = Convert.ToDecimal(producto.PrecioUnidadCompra),
                                PrecioUnitarioVenta = Convert.ToDecimal(producto.PrecioUnidadVenta),
                                SaldoCantidad = Convert.ToInt32(saldo),
                                Total = Convert.ToInt32((pid.Stock - producto.Stock) * producto.PrecioUnidadVenta)
                            };
                            _context.Add(kardexS);
                        }
                        await _context.SaveChangesAsync();
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.IdProducto))
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
            ViewData["IdCategoria"] = new SelectList(lst, "IdCategoria", "Descripcion", producto.IdCategoria);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Producto
                .Include(p => p.IdCategoriaNavigation)
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }
        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            

            var producto = await _context.Producto.FindAsync(id);
            _context.Producto.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExists(int id)
        {
            return _context.Producto.Any(e => e.IdProducto == id);
        }
    }
}