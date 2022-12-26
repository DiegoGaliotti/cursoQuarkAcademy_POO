using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_ElSoldado
{
    internal class Rifle : Arma
    {

        
        //Atributo
        public Rifle()
        {
            nombre = "Rifle";
        }
        //Metodo
        public override string dispararArma()
        {
            return "¡Púm púm púm!...";
        }
        public override string llamarArmar()
        {
            return Nombre;
        }
    }
}
