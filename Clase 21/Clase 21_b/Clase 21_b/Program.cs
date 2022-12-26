namespace Clase_21_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materia lab2 = new Materia("Matematicas");

            Tema t1 = new Tema("Vectores");
            Tema t2 = new Tema("Matrices");

            lab2.agregarTema(t1);
            lab2.agregarTema(t2);

            Console.WriteLine("Los temas de la materia " + lab2.Nombre+ " son: ");
            foreach (Tema t in lab2.Temas)
            {
                Console.WriteLine("- "+t.Nombre);
            }

            t1.Materia = lab2;
            t2.Materia = lab2;

            Console.WriteLine("Los temas " + t1.Nombre + " y " + t2.Nombre + " se dicatan en " + t1.Materia.Nombre);
        }
    }
}