using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21_c
{
    class Mesa
    {
        private List<Pata> patas;
        public List<Pata> Patas { get { return patas; } }
        public Mesa(int cantDePatas)
        {
            this.patas = new List<Pata>();

            for (int i = 0; i < cantDePatas; i++)
            {
                this.patas.Add(new Pata());
            }
        }
        internal class Pata //por esto se usa internal, por que es una clase interna. 
        {
            private string color = "blanco";
            public string Color { get { return color; } }
        }
    }
}
