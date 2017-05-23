using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// Clase que almacena las opciones de la 2da parte de la encuesta
/// </summary>
namespace NewProject.Models
{ 
    public class Clasificacion_Tipos
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Nombre { get; set; }

        [ForeignKey("Tipos_Detalles"),Column(Order =0)]
        public int DetalleId { get; set; }

        public virtual Tipos_Detalles Tipos_Detalles { get; set; }
    }
}
