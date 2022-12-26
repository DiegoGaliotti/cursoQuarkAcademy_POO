using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21_b
{
    internal class Materia
    {
        private string nombre;
        private List<Tema> temas;
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<Tema> Temas { get { return temas; } }
        public Materia(string nombre)
        {
            this.nombre = nombre;
            this.temas = new List<Tema>();
        }
        public void agregarTema(Tema t)
        {
            temas.Add(t);
        }
    }
}
