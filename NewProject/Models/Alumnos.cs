using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Alumnos
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Personas_Naturales"),Column(Order =0)]
        public int PersonaId { get; set; }

        public virtual Personas_Naturales Personas_Naturales { get; set; }

        //TBD
        public string Carrera { get; set; }
        public string Colegio { get; set; }
        public string Telefono { get; set; }
        public string Curso { get; set; }
    }
}