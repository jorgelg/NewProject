using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Telefonos_Turnos
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Turnos"),Column(Order =0)]
        public int TurnoId { get; set; }

        [ForeignKey("Telefonos"),Column(Order =1)]
        public int TelefonoId { get; set; }

        public virtual Turnos Turnos { get; set; }

        public virtual  Telefonos Telefonos { get; set; }
    }
}
