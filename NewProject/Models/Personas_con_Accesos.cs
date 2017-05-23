using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Personas_con_Accesos
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Personas_Naturales"),Column(Order =0)]
        public int PersonaId { get; set; }

        public virtual Personas_Naturales Personas_Naturales { get; set; }
    }
}
