using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace NewProject.Models
{
    public class Turnos
    {
        [Key]
        public int Id { get; set; }

        public string Descripcion { get; set; }

        [ForeignKey("Directores"),Column(Order =0)]
        public int DirectorId { get; set; }

        [ForeignKey("Contactos"),Column(Order =1)]
        public int ContactoId { get; set; }


        public bool Activo { get; set; }

        public virtual Directores Directores { get; set; }
        public virtual Contactos Contactos { get; set; }
    }
}