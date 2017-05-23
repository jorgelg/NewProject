using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Ciudades
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        [ForeignKey("Provincias"),Column(Order =0)]
        public int ProvinciaId { get; set; }

        public virtual Provincias Provincias { get; set; }
    }
}
