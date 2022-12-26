using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21
{
    internal class ProfesorTitular
    {
        private string nombre;
        private List<Materia> materias = new List<Materia>(); //esta relación la armo de uno en muchos, por eso la lista de Materias

        //Propiedades
        public string Nombre { get { return nombre; } }
        internal List<Materia> Materias { get => materias; }

        //Constructor
        public ProfesorTitular(string nombre)
        {
            this.nombre = nombre;
        }

        //Metodos
        public void agregarMaterias(Materia materia)
        {
            Materias.Add(materia);
        }

    }
}
