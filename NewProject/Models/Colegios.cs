using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewProject.Models
{
    public class Colegios
    {
        [Key]
        public int Id { get; set; }
        
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        
        [DataType(DataType.Text)]
        public string Direccion { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set;}
    }
}