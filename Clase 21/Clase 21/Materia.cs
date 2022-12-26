using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21
{
    internal class Materia
    {
        //Atributo
        private string nombre;
        private ProfesorTitular profesor; 
        //Propiedades
        public string Nombre { get { return nombre; } }
        public ProfesorTitular Profesor { get { return profesor; } set { profesor = value; } }   
        //Constructor
        public Materia(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
