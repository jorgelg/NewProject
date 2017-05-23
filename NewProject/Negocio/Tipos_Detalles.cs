using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Negocio
{
    public class Tipos_Detalles
    {
        public string Nombre;

        public Tipos_Detalles()
        {

        }

        public Tipos_Detalles(string n)
        {
            Nombre = n;
        }

        public Tipos_Detalles getInstance()
        {
            return this;
        }
    }
}
