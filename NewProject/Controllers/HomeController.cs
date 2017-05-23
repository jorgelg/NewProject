using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewProject.Models;
using System.Net.Mail;
using System.Net;
using System.Net.NetworkInformation;

namespace NewProject.Controllers
{
    public class HomeController : Controller
    {
        //private bool CheckForInternetConnetion()
        //{
        //    try{
        //        Ping p = new Ping();
        //        if (p.Send("www.google.com",500).Status == IPStatus.Success)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    catch(Exception e)
        //    {
        //        ModelState.AddModelError("", e.Message);
        //        return false;
        //    }
        //}
        // GET: Home
        [AllowAnonymous]
        public ActionResult Index()
        {
            var db = new MainDbContext();
            return View(/*db.Alumnos.ToList()*/);
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Formulario()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult EnviarPrueba()
        {


            ////if (CheckForInternetConnetion())
            ////{
            //    SmtpClient smtp = new SmtpClient();
            //    MailMessage mail = new MailMessage();
            //    smtp.Credentials = new NetworkCredential("prupsa1@gmail.com", "promoupsa123");
            //    smtp.Port = 587;
            //    smtp.EnableSsl = true;
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.UseDefaultCredentials = false;
            //    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //    mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            //    mail.From = new MailAddress("prupsa1@gmail.com");

            //    mail.To.Add("jorge.gutierrezf3@gmail.com");
            //    //mail.attachments.add(new attachment(ubicacionarchivo))
            //    mail.Subject = "prueba";
            //    mail.Body = "prueba";
            //    smtp.Send(mail);


            //}
            //else
            //{
            //    ModelState.AddModelError("", "no hay internet");
            //}



            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("prupsa1@gmail.com");

            // The important part -- configuring the SMTP client
            SmtpClient smtp = new SmtpClient();
            smtp.Port = 587;   // [1] You can try with 465 also, I always used 587 and got success
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // [2] Added this
            smtp.UseDefaultCredentials = false; // [3] Changed this
            smtp.Credentials = new NetworkCredential(mail.From.Address, "promoupsa123");  // [4] Added this. Note, first parameter is NOT string.
            smtp.Host = "smtp.gmail.com";

            //notificacion
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;

            //recipient address
            mail.To.Add(new MailAddress("jorge.gutierrezf3@gmail.com"));

            //Formatted mail body
            mail.IsBodyHtml = true;
            string st = "Test";

            mail.Body = st;
            smtp.Send(mail);

            return RedirectToAction("Index", "Home");
        }


        [AllowAnonymous]
        [HttpPost]
        public ActionResult Formulario(Formularios formulario)
        {
            if (ModelState.IsValid)
            {
                using (var db=new MainDbContext())
                {
                    #region "RegistroPersona"
                    var persona = db.Personas_Naturales.Create();
                    persona.Activo = true;
                    persona.Nombres = formulario.Nombre;
                    persona.Apellido_Paterno = formulario.Apellido_Paterno;
                    persona.Apellido_Materno = formulario.Apellido_Materno;
                    persona.Email = formulario.Email;
                    persona.CI = formulario.CI;
                    db.Personas_Naturales.Add(persona);
                    db.SaveChanges();
                    #endregion
                    var form = db.Alumnos.Create();
                    form.Carrera = formulario.Carrera;
                    form.Colegio = formulario.Colegio;
                    form.Telefono = formulario.Telefono;
                    form.Curso = formulario.Curso;
                    //form.Personas_Naturales = db.Personas_Naturales.Single(u => u.CI == formulario.Personas_Naturales.CI);
                    form.PersonaId = db.Personas_Naturales.Single(u => u.CI == formulario.CI).Id;
                    db.Alumnos.Add(form);
                    db.SaveChanges();
                }
            }
            else
            {
                ModelState.AddModelError("", "Formato de registro incorrecto");
            }
            
                return RedirectToAction("Index", "Home");
            
            
        }
    }
}