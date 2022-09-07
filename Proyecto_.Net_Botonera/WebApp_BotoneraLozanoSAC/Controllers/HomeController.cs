using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApp_BotoneraLozanoSAC.Models;

using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebApp_BotoneraLozanoSAC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        static int R=0;
        static int count = 0;
        static int layout = 0;
        
        private readonly APP_IBL_SACContext _context;
        
        public HomeController(APP_IBL_SACContext objcontext)
        {
            _context = objcontext;
        }
        public async Task<IActionResult> Index(String searchString)
        {
            String us = User.Identity.Name;
            var user = from s in _context.Usuario.Include(x=>x.IdRolNavigation) select s;
            var user1 = user.First(x=>x.Correo==us);
            
            
            if (user1.IdRol ==1 )
            {
                layout = 1;
                ViewBag.l = 1;
            }
            else {
                layout = 0;
                ViewBag.l = 0
                    ;
            }
            ViewBag.Layout = layout;
            ViewBag.Valor = R;
            count += R;
            if (count > 1)
            {
                ViewBag.Valor = 0;
                count = 0;
                R = 0;
            }
            ViewBag.UsuarioActual = user1.Nombres;
            ViewBag.Rol = user1.IdRolNavigation.Descripcion+": ";
            ViewBag.Producto = 1;
            ViewData["CurrentFilter"] = searchString;
            var productos = from s in _context.Producto.Include(u => u.IdCategoriaNavigation).Where(x=>x.Stock>0 && x.Activo==true) select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                
                productos = productos.Where(s => 
                s.Nombre.Contains(searchString)).Where(x=>x.Stock>0);

                var countpro = productos.Count();
                if(countpro==0){
                    ViewBag.Producto = 0;
                }

            }

            return View(await productos.ToListAsync());


        }
        public async Task<IActionResult> AgregarCarrito(int? id)
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
            ViewData["Id"] = producto.IdProducto;
            ViewData["Nombre"] = producto.Nombre;
            ViewData["Imagen"] = producto.ImagenUrl;
            ViewData["PrecioVenta"] = producto.PrecioUnidadVenta;
            ViewData["Stock"] = producto.Stock;
            R = 0;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AgregarCarrito(int? id, Carrito carrito)
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
            ViewData["Id"] = producto.IdProducto;
            ViewData["Nombre"] = producto.Nombre;
            ViewData["Imagen"] = producto.ImagenUrl;
            ViewData["PrecioVenta"] = producto.PrecioUnidadVenta;
            ViewBag.Stock = producto.Stock;
            ViewBag.Cantidad = carrito.Cantidad;
            ViewBag.Sucess = 0;

            var var1 = from s in _context.Carrito select s;
            var var2 = var1.FirstOrDefault(x => x.IdProducto == id);
            if (var2 == null)
            {

                if (ModelState.IsValid)
                {
                    var car = carrito;
                    car.IdProducto = producto.IdProducto;
                    car.Cantidad = Convert.ToInt32(carrito.Cantidad);
                    car.PrecioUnidad = Convert.ToDecimal((producto.PrecioUnidadVenta));
                    car.Total = Convert.ToInt32(carrito.Cantidad * Convert.ToDecimal((producto.PrecioUnidadVenta)));

                    _context.Carrito.Add(car);
                    ViewBag.Sucess = 1;
                    await _context.SaveChangesAsync();
                    R = 1;
                    return RedirectToAction(nameof(Index));

                }
            }
            
            ViewBag.Sucess = 2;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Reseña()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

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

        public async Task<IActionResult> ProductoVista(int? id)
        {
            var car = await _context.Producto.FirstAsync(x => x.IdProducto == id);
            return View(car);
        }

        public IActionResult Crear()
        {

            return View();
        }


        // POST: Carritoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.


        // POST: Carritoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    }
}