using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21_b
{
    internal class Tema
    {
        private string nombre;
        private Materia materia;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public Materia Materia { get { return materia; } set { materia = value; } }
        public Tema(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
