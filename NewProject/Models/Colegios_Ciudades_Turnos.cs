using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Colegios_Ciudades_Turnos
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Colegios"),Column(Order =0)]
        public int ColegioId { get; set; }

        [ForeignKey("Ciudades"),Column(Order =1)]
        public int CiudadId { get; set; }

        [ForeignKey("Turnos"),Column(Order =2)]
        public int TurnoId { get; set; }

        public virtual Colegios Colegios { get; set; }

        public virtual Ciudades Ciudades { get; set; }

        public virtual Turnos Turnos { get; set; }
    }
}
