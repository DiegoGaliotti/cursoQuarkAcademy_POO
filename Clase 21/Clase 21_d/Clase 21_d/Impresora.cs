using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21_d
{
    internal class Impresora
    {
        public void imprimir(Documento doc) //Dependiencia
        {
            Console.WriteLine(doc.Texto);
        }
    }
}
