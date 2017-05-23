using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Relaciones entre los alumnos y la encuesta
/// </summary>
namespace NewProject.Models
{
    public class Detalles_Alumnos
    {
        [Key]
        public int Id { get; set;}

        [ForeignKey("Alumnos"),Column(Order =0)]
        public int AlumnoId { get; set; }

        [ForeignKey("Clasificacion_Tipos"),Column(Order =1)]
        public int ClasificacionId { get; set; }

        public virtual Alumnos Alumnos { get; set; }
        public virtual Clasificacion_Tipos Clasificacion_Tipos { get; set; }
    }
}
