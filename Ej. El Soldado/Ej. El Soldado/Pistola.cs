using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_ElSoldado
{
    internal class Pistola : Arma
    {
        
        //Atributo
        public Pistola()
        {
            nombre = "Pistola";
        }

        //Metodo
        public override string dispararArma()
        {
            return "Púm...";
        }

        public override string llamarArmar()
        {
            return Nombre;
        }
    }
}
