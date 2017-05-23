using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewProject.Models;
using System.Security.Claims;
using NewProject.CustomLibraries;
using NewProject.Controls;


namespace NewProject.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        ctlAccess acceso;

        public AuthController()
        {
            acceso = new ctlAccess();
        }
        // GET: Auth
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Usuarios model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            try
            {
                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;
                var identity = acceso.IniciarSesion(model.UserId, model.Password);
                    authManager.SignIn(identity);
                    return RedirectToAction("Index", "Home");
                    //Response.Write("<script>alert('" + Server.HtmlEncode("Usuario inexistente/password incorrecta...") + "')</script>");
            }
            catch(Exception e)
            {
                ModelState.AddModelError("ERROR", Server.HtmlEncode(e.Message));
                return View(model);
            }
            
            
        }

        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;
            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Usuarios model)
        {
            if (ModelState.IsValid)
            {
                string confirmacion = Request.Form["confirmacion"];
                if (model.Password == confirmacion)
                {
                    try
                    {
                        var person = model.Personas_con_Accesos.Personas_Naturales;
                        if (acceso.CrearUsuario(person.Nombres,person.Apellido_Paterno,person.Apellido_Materno,person.Email,person.CI,model.UserId,model.Password))
                        {
                            return RedirectToAction("Login", "Auth");
                        }
                        else
                        {
                            throw new Exception("Error al registrar nuevo usuario...");
                        }
                    }
                    catch (Exception e)
                    {
                        ModelState.AddModelError("ERROR", Server.HtmlEncode(e.Message));
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Las contraseñas no coinciden");
                    return View(model);
                }
            }
            else
            {
                ModelState.AddModelError("", "Error con datos");
                return View(model);
            }
            
        }
    }
}