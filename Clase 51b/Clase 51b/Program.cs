using System.Numerics;

namespace Clase51b
{
    class Recursividad
    {
        int[] vector = { 2, 434, 532, 34, 56 };

        void Imprimir()
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
            Console.WriteLine("");
        }
        void Ordenar(int[] vector, int cant )
        {
            
            if (cant > 1)
            {
                for (int i = 0; i < vector.Length - 1; i++)
                {
                    if (vector[i] > vector[i + 1])
                    {
                        int aux = vector[i + 1];
                        vector[i + 1] = vector[i];
                        vector[i] = aux;
                    }
                }
                Ordenar(vector, cant - 1);
            }
            
        }

        void Procesar()
        {
            Ordenar(vector, vector.Length);
        }
        static void Main()
        {
            Recursividad re = new Recursividad();
            re.Imprimir();
            re.Procesar();
            re.Imprimir();

            Console.ReadKey();
        }

        /*
        public int Imprimir(int x)
        {
            int i = 0;
            if(x > 0)
            {
                i = x * (Imprimir(x - 1));
                
                return i;
            }
            else
            {
                return 1;
            }
            
        }

        static void Main()
        {
            Recursividad re = new Recursividad();
            int r = re.Imprimir(4);
            Console.WriteLine("el valor de x es: " + r);
        }
        */
    }
}