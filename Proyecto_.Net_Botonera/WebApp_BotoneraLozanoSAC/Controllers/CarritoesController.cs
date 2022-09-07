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
    public class CarritoesController : Controller
    {
        private readonly APP_IBL_SACContext _context;
        static double Total;
        static double TotalWOEnvio;
        public CarritoesController(APP_IBL_SACContext context)
        {
            _context = context;
        }

        // GET: Carritoes1
        public async Task<IActionResult> Index(String searchString )
        {
            var productos = from s in _context.Carrito.Include(x=>x.IdProductoNavigation) select s;
            var pro = from s in _context.Producto select s;
            ViewData["CurrentFilter"] = searchString;
                                   

            var st = from s in _context.Carrito select s.Total;
            var total = st.Sum();
            ViewData["total"] = total;
            

            var c = from s in _context.Carrito select s;
            var ca = c.Count();
            

            ViewBag.Valor = ca;
            ViewBag.SubTotal = total-(total*0.18);
            ViewBag.Envio = 10;
            if (total>100)
            {
                ViewBag.Envio = 0;
            }
            ViewBag.Igv = Math.Round(total * (0.18), 4);
            TotalWOEnvio = total;
            ViewBag.Total = total+ViewBag.Envio;
            Total = ViewBag.Total;
            if (!String.IsNullOrEmpty(searchString))
            {
                var pe = (pro.Where(s => s.Nombre.Contains(searchString))).ToList();
                List<Carrito> car = new List<Carrito>();
                foreach (var pp in pe)
                {
                    foreach (var ss in productos)
                    {
                        if (pp.IdProducto == ss.IdProducto)
                        {
                            
                            car.Add(ss);
                        }

                        
                    }
                }
                return View(car);
            }
            return View(await productos.ToListAsync());
        }





        public IActionResult CrearBoleta()
        {
            Venta venta = new Venta();
            var total = from s in _context.Carrito select s;
            var sumaPrecios = total.Sum(x => x.Total);
            var sumatotal = sumaPrecios + 10;
            var sumaProductos = total.Count();
            var user = _context.Usuario.First(x => x.Correo == (User.Identity.Name));
            var id = from s in _context.Venta select s.IdVenta;

            if (id.Count() != 0)
            {

                var may = id.Max();
                venta.Codigo = "B" + Convert.ToString(may + 1) + Convert.ToString(user.IdUsuario);
            }
            else
            {
                var may = 1;
                venta.Codigo = "B" + Convert.ToString(may + 1) + Convert.ToString(user.IdUsuario);
            }


            venta.ValorCodigo = 1;
            venta.IdUsuario = user.IdUsuario;
            venta.TipoDocumento = user.NumeroDocumento;
            venta.CantidadProducto = sumaProductos;
            venta.TotalCosto = Convert.ToDecimal(sumaPrecios);
            venta.TotalCosto = Convert.ToDecimal(Total);
            _context.Venta.Add(venta);
            _context.SaveChanges();


            var car = from s in _context.Carrito select s;

            foreach (var objcar in car)
            {
                var detalle = new DetalleVenta()
                {
                    IdVenta = venta.IdVenta,
                    IdProducto = objcar.IdProducto,
                    Cantidad = objcar.Cantidad,
                    PrecioUnidad = objcar.PrecioUnidad,
                    ImporteTotal = objcar.Total,

                };


                _context.DetalleVenta.AddRange(detalle);

                _context.Carrito.Remove(objcar);

            }
            
            _context.SaveChanges();


            var v1 = (from s in _context.Venta select s).AsNoTracking().ToList();
            var v2 = v1.OrderByDescending(x => x.IdVenta).First();
            var v3 = (from a in _context.DetalleVenta select a).AsNoTracking().ToList();
            var v4 = v3.Where(x => x.IdVenta == v2.IdVenta).ToList();
            var producto = (from s in _context.Producto select s).AsNoTracking().ToList();
            List<Producto> pro = new List<Producto>();
            List<DetalleVenta> detalles = new List<DetalleVenta>();
            foreach (var item in v4)
            {
                var a = producto.First(x => x.IdProducto == item.IdProducto);
                detalles.Add(item);
                pro.Add(a);
            }

            List<Producto> productoUpdate = new List<Producto>();
            List<Kardex> kardexAdd = new List<Kardex>();
            foreach (var p in detalles)
            {
                foreach (var item in pro)
                {
                    if (item.IdProducto == p.IdProducto)
                    {
                        var prod = new Producto()
                        {
                            IdProducto = item.IdProducto,
                            Descripcion = item.Descripcion,
                            IdCategoria = item.IdCategoria,
                            ImagenUrl = item.ImagenUrl,
                            Nombre = item.Nombre,
                            Stock = item.Stock - p.Cantidad,
                            PrecioUnidadCompra = item.PrecioUnidadCompra,
                            PrecioUnidadVenta = item.PrecioUnidadVenta,
                            Activo = item.Activo,
                            FechaRegistro = item.FechaRegistro
                        };
                        productoUpdate.Add(prod);

                        Kardex kardex = new Kardex()
                        {
                            IdProducto = item.IdProducto,
                            EntradaCantidad = 0,
                            SalidaCantidad = p.Cantidad,
                            FechaRegistro = item.FechaRegistro,
                            Documento=p.IdVenta,
                            PrecioUnitarioCompra = item.PrecioUnidadCompra,
                            PrecioUnitarioVenta = item.PrecioUnidadVenta,
                            SaldoCantidad = Convert.ToInt32(item.Stock - p.Cantidad),
                            Total = Convert.ToInt32(p.Cantidad) * item.PrecioUnidadVenta
                        };
                        kardexAdd.Add(kardex);
                    }

                }



            }
            _context.Producto.UpdateRange(productoUpdate);
            

            _context.Kardex.AddRange(kardexAdd);
             _context.SaveChanges();

            return RedirectToAction(nameof(Confirmacion));

        }
         
        


        public IActionResult Confirmacion()
        {
            var v = from s in _context.Venta select s;
            var va = v.OrderByDescending(x => x.IdVenta);
            var vaa = va.First();
            var us = from s in _context.Usuario select s;
            var usuario = us.FirstOrDefault(x => x.IdUsuario == vaa.IdUsuario);
            ViewBag.Cantidad = vaa.CantidadProducto;
            ViewBag.Direccion = usuario.Direccion;
            ViewBag.SubTotal =TotalWOEnvio - (TotalWOEnvio *0.18);
            ViewBag.Envio = vaa.TotalCosto - Convert.ToDecimal(TotalWOEnvio);
            ViewBag.Total = vaa.TotalCosto;
            ViewBag.Codigo = vaa.Codigo;
            ViewBag.Usuario = usuario.Nombres + " " + usuario.Apellidos;
            ViewBag.Fecha = vaa.FechaRegistro;
            ViewBag.Igv =Math.Round(TotalWOEnvio*(0.18),4);
            return View();
        }




        public IActionResult Pago()
        {
            
            var st = from s in _context.Carrito select s.Total;
            var total = st.Sum();
            ViewBag.SubTotal = Total;
            ViewBag.Total =Total ;
            return View();
        }
        // GET: Carritoes1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito
                .Include(c => c.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.IdCarrito == id);
            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        // GET: Carritoes1/Create
        public IActionResult Create()
        {
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "IdProducto");
            return View();
        }

        // POST: Carritoes1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCarrito,IdProducto,Cantidad,PrecioUnidad,Total")] Carrito carrito)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carrito);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "IdProducto", carrito.IdProducto);
            return View(carrito);
        }

        // GET: Carritoes1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito.FindAsync(id);
            if (carrito == null)
            {
                return NotFound();
            }
            var var1 = from s in _context.Producto select s;
            var var2 = var1.FirstOrDefault(x => x.IdProducto == carrito.IdProducto);
            ViewBag.Nombre = var2.Nombre;
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "IdProducto", carrito.IdProducto);
            return View(carrito);
        }

        // POST: Carritoes1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCarrito,IdProducto,Cantidad,PrecioUnidad,Total")] Carrito carrito)
        {
            
            if (id != carrito.IdCarrito)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var car = new Carrito()
                    {
                        IdProducto = carrito.IdProducto,
                        Cantidad = carrito.Cantidad,
                        IdCarrito = carrito.IdCarrito,
                        PrecioUnidad = carrito.PrecioUnidad,
                        Total = Convert.ToInt32(carrito.Cantidad * carrito.PrecioUnidad)
                    };
                    
                        _context.Update(car);
                        await _context.SaveChangesAsync();
                    
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarritoExists(carrito.IdCarrito))
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
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "IdProducto", carrito.IdProducto);
            return View(carrito);
        }

        // GET: Carritoes1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carrito = await _context.Carrito
                .Include(c => c.IdProductoNavigation)
                .FirstOrDefaultAsync(m => m.IdCarrito == id);
            if (carrito == null)
            {
                return NotFound();
            }

            return View(carrito);
        }

        // POST: Carritoes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carrito = await _context.Carrito.FindAsync(id);
            _context.Carrito.Remove(carrito);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarritoExists(int id)
        {
            return _context.Carrito.Any(e => e.IdCarrito == id);
        }
    }
}
