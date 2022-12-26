using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_ElSoldado
{
    internal class Escopeta : Arma
    {

        //public string Nombre { get; }
        //Atributo
        public Escopeta()
        {
            nombre = "Escopeta";
        }
        //Metodo
        public override string dispararArma()
        {
            return "¡Pááááá!...";
        }
        public override string llamarArmar()
        {
            return Nombre;
        }
    }
}
