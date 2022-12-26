namespace Clase_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Materia lab2 = new Materia("Laboratorio 2");
            Materia lab3 = new Materia("Laboratorio 3");

            ProfesorTitular profeJesus = new ProfesorTitular("Jesus Arce");

            lab2.Profesor = profeJesus;
            lab3.Profesor = profeJesus;

            profeJesus.agregarMaterias(lab2);
            profeJesus.agregarMaterias(lab3);

            // Si elimino alguna materia, el profeso sigue existiendo. 

            foreach (Materia m in profeJesus.Materias)
            {
                Console.WriteLine(m.Nombre);
            }

            Console.WriteLine(lab2.Nombre + ": " + lab2.Profesor.Nombre);
            Console.WriteLine(lab3.Nombre + ": " + lab3.Profesor.Nombre);

            Console.ReadLine();
        }
    }
}