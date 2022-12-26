using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_ElSoldado
{
    internal static class Armas_factory
    {
        //Constantes
        public const int Pistola = 1;
        public const int Rifle = 2;
        public const int Escopeta = 3;

        internal static Arma GetArma(int armaSeleccionada)
        {
            switch (armaSeleccionada)
            {
                case Pistola:
                    return new Pistola();
                case Escopeta:
                    return new Escopeta();
                case Rifle:
                    return new Rifle();
                default:
                    return null;

            }
        }

    }
}
