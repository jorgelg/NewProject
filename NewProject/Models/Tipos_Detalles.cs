using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Clase que almacena las categorias de las preguntas
/// </summary>
namespace NewProject.Models
{
    public class Tipos_Detalles
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Nombre { get; set; }
    }
}
