using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Models
{
    public class Estudiantes_Visitantes
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Personas_Naturales"),Column(Order =0)]
        public int PersonaId { get; set; }

        [ForeignKey("Colegios"), Column(Order = 1)]
        public int ColegioId { get; set; }

        public string Curso { get; set; }

        [ForeignKey("Carreras"), Column(Order = 2)]
        public int CarreraId { get; set; }
    }
}
