using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21_d
{
    internal class Documento
    {
        private string texto = "";
        public string Texto { get { return texto; } }
        public Documento(string texto)
        {
            this.texto = texto;
        }
    }
}
