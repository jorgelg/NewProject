using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewProject.Models;
using System.Data.Entity;

namespace NewProject.Controllers
{
    public class ColegiosController : Controller
    {
        // GET: Colegios
        public ActionResult Index()
        {
            var db = new MainDbContext();
            return View(db.Colegios_Ciudades_Turnos.ToList());
        }

        public ActionResult Nuevo()
        {
            var modelo = new ModelForColegio();
            return View(modelo);
        }

        [HttpPost]
        public ActionResult Nuevo(ModelForColegio modelo)
        {
            if (ModelState.IsValid)
            {
                using (var db=new MainDbContext())
                {
                    var colegio = db.Colegios.Create();
                    colegio.Nombre = modelo.Nombre;
                    colegio.Direccion = modelo.Direccion;
                    colegio.Email = modelo.Email;
                    db.Colegios.Add(colegio);
                    db.SaveChanges();

                    var dpto = db.Departamentos.Create();
                    var provincia = db.Provincias.Create();
                    var ciudad = db.Ciudades.Create();

                    dpto.Nombre = modelo.Departamento;
                    db.Departamentos.Add(dpto);
                    db.SaveChanges();
                    provincia.Nombre = modelo.Provincia;
                    provincia.DepartamentoId = db.Departamentos.Single(u => u.Nombre == modelo.Departamento).Id;
                    db.Provincias.Add(provincia);
                    db.SaveChanges();
                    ciudad.Nombre = modelo.Ciudad;
                    ciudad.ProvinciaId = db.Provincias.Single(u => u.Nombre == modelo.Provincia).Id;
                    db.Ciudades.Add(ciudad);
                    db.SaveChanges();

                   
                    var persona = db.Personas_Naturales.Create();
                    persona.Activo = true;
                    persona.Nombres = modelo.Director;
                    db.Personas_Naturales.Add(persona);
                    db.SaveChanges();
                    var director = db.Directores.Create();
                    var persona_con_acceso = db.Personas_con_Accesos.Create();
                    persona_con_acceso.PersonaId = db.Personas_Naturales.Single(u => u.Nombres == modelo.Director).Id;
                    db.Personas_con_Accesos.Add(persona_con_acceso);
                    db.SaveChanges();
                    director.PersonaId= db.Personas_con_Accesos.SingleOrDefault(u => u.Personas_Naturales.Nombres == modelo.Director).Id;
                    db.Directores.Add(director);
                    db.SaveChanges();

                    var persona2 = db.Personas_Naturales.Create();
                    persona2.Activo = true;
                    persona2.Nombres = modelo.Contacto;
                    db.Personas_Naturales.Add(persona2);
                    db.SaveChanges();
                    var contacto = db.Contactos.Create();
                    var persona_con_acceso2 = db.Personas_con_Accesos.Create();
                    persona_con_acceso2.PersonaId = db.Personas_Naturales.Single(u => u.Nombres == modelo.Contacto).Id;
                    db.Personas_con_Accesos.Add(persona_con_acceso2);
                    db.SaveChanges();
                    contacto.PersonaId = db.Personas_con_Accesos.SingleOrDefault(u => u.Personas_Naturales.Nombres == modelo.Contacto).Id;
                    db.Contactos.Add(contacto);
                    db.SaveChanges();

                    var turno = db.Turnos.Create();
                    turno.Activo = true;
                    turno.ContactoId = db.Contactos.Single(u => u.Personas_con_Accesos.Personas_Naturales.Nombres == modelo.Contacto).Id;
                    turno.Descripcion = modelo.Turno;
                    turno.DirectorId = db.Directores.Single(u => u.Personas_con_Accesos.Personas_Naturales.Nombres == modelo.Director).Id;
                    db.Turnos.Add(turno);
                    db.SaveChanges();

                    var colciutur = db.Colegios_Ciudades_Turnos.Create();
                    colciutur.ColegioId = db.Colegios.Single(u => u.Nombre == modelo.Nombre).Id;
                    colciutur.TurnoId = db.Turnos.Single(u => u.Descripcion == modelo.Turno).Id;
                    colciutur.CiudadId = db.Ciudades.Single(u => u.Nombre == modelo.Ciudad).Id;
                    db.Colegios_Ciudades_Turnos.Add(colciutur);
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index", "Colegios");
        }
    }
}