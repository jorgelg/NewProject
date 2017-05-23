using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using NewProject.Models;
namespace NewProject.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: Alumnos

        public ActionResult Index()
        {
            var db = new MainDbContext();
            return View(db.Alumnos.ToList());
        }
    }
}