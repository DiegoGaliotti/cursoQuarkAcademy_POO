using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_ElSoldado
{
    abstract class Arma
    {
        protected string nombre;
        public string Nombre { get; }

        //Metodo
        public abstract string dispararArma();
        public abstract string llamarArmar();

        internal static Arma Recoger(int armaSeleccionada)
        {
            return Armas_factory.GetArma(armaSeleccionada);
        }
    }
}
