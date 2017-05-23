using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Models
{
    public class Permisos
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Descripcion { get; set; }
    }
}
