using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_ElSoldado
{
    public class Soldado
    {
        //Atributo
        
        private Arma armaActual;


        //Metodo
        public string recogerArma(int opcionSeleccionada)
        {
            if (armaActual != null)
            {
                return "El soldado está equipado...";
            }
            else
            {
                armaActual = Arma.Recoger(opcionSeleccionada);
                return ("El soldado ha sido equipado con " + armaActual.Nombre);
            }
      
        }
        public string dejarArma()
        {
            if (armaActual != null)
            {
                armaActual = null;
                return "El soldado ha dejado el arma, ahora está desarmado";
            }
            else
                return "El soldado está desarmado, no tiene arma para dejar";
        }
        public string dispararArma()
        {
            if (armaActual != null)
            {
                return armaActual.dispararArma();
            }

            else
            {
                return "El soldado está desarmado";
            }

        }
        public string verArmaActual()
        {
            if (armaActual != null)
            {
                return armaActual.Nombre;
            }
            else
            {
                return "El soldado está desarmado";
            }

        }

    }
}
