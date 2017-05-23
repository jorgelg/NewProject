using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Models
{
    public class Telefonos
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }
        
        public bool Activo { get; set; }
    }
}
