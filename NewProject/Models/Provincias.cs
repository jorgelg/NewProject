using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Provincias
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        [ForeignKey("Departamentos"),Column(Order =0)]
        public int DepartamentoId { get; set; }

        public virtual Departamentos Departamentos { get; set; }
    }
}
