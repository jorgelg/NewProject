using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NewProject.Models
{
    public class Cursos
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name ="Curso")]
        public string Nombre { get; set; }
    }
}
