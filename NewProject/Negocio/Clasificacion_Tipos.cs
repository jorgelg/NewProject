using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Negocio
{
    public class Clasificacion_Tipos
    {
        List<Tipos_Detalles> Selecciones;
        public string Clasificacion;
        public void insertar(string tipo_detalle)
        {
            Selecciones.Add(new Tipos_Detalles(tipo_detalle));
        }

    }
}
