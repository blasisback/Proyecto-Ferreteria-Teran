using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// Librerias para consumo de Web Services

using System.Net.Http;
using System.Net.Http.Headers;

//Librerias para el fomateo de los Objetos Json
using System.Text;
using Newtonsoft.Json;
using WebApp_BotoneraLozanoSAC.Models;
using WebApp_IBL_SAC.ViewModels;

namespace WebApp_BotoneraLozanoSAC.Controllers
{
    [Authorize]
    public class CategoriasController : Controller
    {
        private readonly APP_IBL_SACContext _context;
        public string BaseUrl { get; set; }

        public CategoriasController(APP_IBL_SACContext context)
        {
            this.BaseUrl = "https://localhost:44382/Api/Categorias";
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index(string searchString)
        {
            List<Categoria> lst = new List<Categoria>();

            HttpClient client = new HttpClient(); // declarando conector

            client.BaseAddress = new Uri(BaseUrl); // Estableciendo URL del servicio
            // Capturando Respuesta HTTP >>>>>      Método Http Get
            HttpResponseMessage resp = await client.GetAsync(""); //

            ViewBag.Producto = 1;
            ViewData["CurrentFilter"] = searchString;
            
            if (!String.IsNullOrEmpty(searchString))
            {
                 resp = await client.GetAsync("?searchString=" + searchString);

                if (resp == null)
                {
                    ViewBag.Producto = 0;
                }
            }

            if (resp.IsSuccessStatusCode)
            { // si llamada es correcta
                //Obteniendo el resultado en cadena
                var readtask = resp.Content.ReadAsStringAsync().Result;
                //deserializa   de cadena a objeto
                lst = JsonConvert.DeserializeObject<List<Categoria>>(readtask);
            }
            return View(lst.ToList());
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Categoria _Cat;
            HttpClient client = new HttpClient(); // declarando conector
            client.BaseAddress = new Uri(BaseUrl + "/" + id.ToString()); // Estableciendo URL del servicio
            // Capturando Respuesta HTTP >>>>>      Método Http Get
            HttpResponseMessage resp = await client.GetAsync("");
            if (resp.IsSuccessStatusCode)
            {
                //si la llamada fue exitosa
                var readtask = resp.Content.ReadAsStringAsync().Result;
                // deseralizar
                _Cat = JsonConvert.DeserializeObject<Categoria>(readtask);
                return View(_Cat);
            }

            return View();
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCategoria,Descripcion,Activo,FechaRegistro")] Categoria categoria)
        {
            try
            {
                Categoria CategoriaResultado = new Categoria();
                HttpClient client = new HttpClient(); // declarando conector
                client.BaseAddress = new Uri(BaseUrl);// Estableciendo URL del servicio
                // Serializar      de objeto a cadena
                StringContent content = new StringContent(JsonConvert.SerializeObject(categoria), Encoding.UTF8, "application/json");
                // Capturando Respuesta HTTP >>>>>      Método Http POST
                HttpResponseMessage resp = await client.PostAsync("", content);
                if (resp.IsSuccessStatusCode)
                {
                    var readtask = resp.Content.ReadAsStringAsync().Result;
                    //deserializa   de cadena a objeto
                    CategoriaResultado = JsonConvert.DeserializeObject<Categoria>(readtask);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            Categoria _Cat;
            HttpClient client = new HttpClient(); // declarando conector
            client.BaseAddress = new Uri(BaseUrl + "/" + id.ToString()); //se establece el url a llamar
            // invocamos verbo Get
            HttpResponseMessage resp = await client.GetAsync("");
            if (resp.IsSuccessStatusCode)
            {
                //si la llamada fue exitosa
                var readtask = resp.Content.ReadAsStringAsync().Result;
                // deseralizar
                _Cat = JsonConvert.DeserializeObject<Categoria>(readtask);
                return View(_Cat);
            }
            return View();
        }

        // POST: Categorias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit( [Bind("IdCategoria,Descripcion,Activo,FechaRegistro")] Categoria categoria)
        {
            try
            {
                Categoria CategoriaResultado = new Categoria();
                HttpClient client = new HttpClient(); // declarando conector
                client.BaseAddress = new Uri(BaseUrl);
                StringContent content = new StringContent(JsonConvert.SerializeObject(categoria), Encoding.UTF8, "application/json");
                HttpResponseMessage resp = await client.PutAsync("", content);
                if (resp.IsSuccessStatusCode)
                {
                    var readtask = resp.Content.ReadAsStringAsync().Result;
                    CategoriaResultado = JsonConvert.DeserializeObject<Categoria>(readtask);
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Categoria _Cat;
            HttpClient client = new HttpClient(); // declarando conector
            client.BaseAddress = new Uri(BaseUrl + "/" + id.ToString()); //se establece el url a llamar
            // invocamos verbo Get
            HttpResponseMessage resp = await client.GetAsync("");
            if (resp.IsSuccessStatusCode)
            {
                //si la llamada fue exitosa
                var readtask = resp.Content.ReadAsStringAsync().Result;
                // deseralizar
                _Cat = JsonConvert.DeserializeObject<Categoria>(readtask);
                return View(_Cat);
            }

            return View();
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                Categoria _Cat = new Categoria();

                HttpClient client = new HttpClient(); // declarando conector
                client.BaseAddress = new Uri(BaseUrl + "/" + id.ToString()); //se establece el url a llamar
                                                                             // invocamos verbo Get
                HttpResponseMessage resp = await client.DeleteAsync("");
                if (resp.IsSuccessStatusCode)
                {
                    //si la llamada fue exitosa
                    var readtask = resp.Content.ReadAsStringAsync().Result;
                    // deseralizar
                    _Cat = JsonConvert.DeserializeObject<Categoria>(readtask);

                    return RedirectToAction(nameof(Index));
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        private bool CategoriaExists(int id)
        {
            return _context.Categoria.Any(e => e.IdCategoria == id);
        }

        public async Task<IActionResult> ReporteCategoria(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;
            var usuarios = from s in _context.Categoria select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                usuarios = usuarios.Where(s => s.Descripcion.Contains(searchString) || s.IdCategoria.ToString().Contains(searchString));
            }
            return View(await usuarios.ToListAsync());
        }
    }
}