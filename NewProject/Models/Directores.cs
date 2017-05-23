using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Directores
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Personas_con_Accesos"),Column(Order =0)]
        public int PersonaId { get; set; }

        public virtual Personas_con_Accesos Personas_con_Accesos { get; set; }
    }
}
