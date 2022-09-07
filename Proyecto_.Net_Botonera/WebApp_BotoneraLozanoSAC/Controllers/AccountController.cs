using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_BotoneraLozanoSAC.Models;
using WebApp_BotoneraLozanoSAC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Session;

namespace WebApp_BotoneraLozanoSAC.Controllers
{
    public class AccountController : Controller
    {
        static String cor = "";
        private readonly APP_IBL_SACContext bd;
        public AccountController(APP_IBL_SACContext context)
        {
            bd = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            ViewData["mensaje"] = "";
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsuarioLogin usuario)
        {
            ViewData["mensaje"] = "";
            if (!string.IsNullOrEmpty(usuario.correo) && string.IsNullOrEmpty(usuario.Contrasena))
            {
                ViewData["mensaje"] = "No ingreso su Correo y/o Contraseña";
                //Si lo enviado es nulo o vacio
                return RedirectToAction("Login");
            }

            //Aqui debemos verificar el usuario y password
            //Podemos llamar a la basae de dato o un servicio
            //https://www.c-sharpcorner.com/article/authentication-and-authorization-in-asp-net-core-mvc-using-cookie/
            //https://stackoverflow.com/questions/44018218/asp-net-core-simplest-possible-forms-authentication/44018596
            //https://www.youtube.com/watch?v=Fhfvbl_KbWo&list=PLOeFnOV9YBa7dnrjpOG6lMpcyd7Wn7E8V


            //if(ModelState.IsValid)
            //{ 
            if (bd.Usuario.Count(x => (x.Clave == usuario.Contrasena && x.Correo == usuario.correo)) > 0)
            {

                //Creamos el objeto identity para el usuario
                // objeto identity estara disponible en todo el proyecto para validar los accesos
                var identity = new ClaimsIdentity(new[] {
                        new Claim(ClaimTypes.Name, usuario.correo)
                    }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);


                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);



                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["mensaje"] = "Error, Correo y/o Contraseña no válidas";
            }
            // }
            return View();
        }
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var car = from s in bd.Carrito select s;
            if (car != null) {
                bd.RemoveRange(car);
                bd.SaveChanges();
            }

            return RedirectToAction("Login", "Account");
        }


        public IActionResult Registrar()
        {
            ViewData["IdRoles"] = new SelectList(bd.Rol, "IdRoles", "Nombre");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registrar([Bind("IdUsuario,Nombres,Apellidos,Correo,Clave,IdRol,Activo,TipoDocumento,NumeroDocumento,Direccion,Telefono,FechaRegistro")] Usuario usuario)
        {
            var us = from s in bd.Usuario select s.Correo;

            var usu = us.Count(x => x == usuario.Correo);
            if (usu == 0)
            {
                if (ModelState.IsValid)
                {
                    bd.Add(usuario);
                    await bd.SaveChangesAsync();
                    return RedirectToAction(nameof(Login));
                }
                ViewData["IdRoles"] = new SelectList(bd.Rol, "IdRoles", "Nombre", usuario.IdRol);
                return View(usuario);

            }
            ViewBag.user = 1;
            return View();
        }

        public IActionResult Verificar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Verificar(UsuarioVerficacion user)
        {

            var u = from s in bd.Usuario select s;
            var us = u.FirstOrDefault(x => x.Correo == user.Correo);

            if (us != null)
            {

                if (us.Correo == user.Correo && us.Nombres == user.Nombres && us.NumeroDocumento == user.NumeroDocumento && us.Apellidos == user.Apellidos)
                {
                    cor = us.Correo;
                    return RedirectToAction(nameof(Recuperar));
                }
            }
            else
            {
                return NotFound();
            }

            return View();
        }

        public IActionResult Recuperar()
        {
            var a = from s in bd.Usuario select s;
            var i = a.FirstOrDefault(x => x.Correo == cor);

            return View(i);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Recuperar([Bind("IdUsuario,Nombres,Apellidos,Correo,Clave,IdRol,Activo,TipoDocumento,NumeroDocumento,Direccion,Telefono,FechaRegistro")] Usuario usuario)
        {


            try
            {
                bd.Update(usuario);
                await bd.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioExists(usuario.IdUsuario))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }

            }
            return RedirectToAction(nameof(Login));

        }

        private bool UsuarioExists(object idusuario)
        {
            throw new NotImplementedException();
        }
    }
}