using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Cursos_Alumnos
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Alumnos"),Column(Order =0)]
        public int AlumnoId { get; set; }

        [ForeignKey("Cursos"),Column(Order =1)]
        public int CursoId { get; set; }

        public virtual Alumnos Alumnos { get; set; }
        public virtual Cursos Cursos { get; set; }
    }
}
