namespace Clase_21_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Documento doc = new Documento("HOLA MUNDO");
            Impresora impresora = new Impresora();

            impresora.imprimir(doc);
            Console.WriteLine(Math.Round(1.76));

            Console.ReadKey();
        }
    }
}