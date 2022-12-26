namespace Clase_21_c
{
    class Program
    {
        static void Main()
        {
            Mesa mesa = new Mesa(1);

            Console.WriteLine("La mesa tiene "+ mesa.Patas.Count() +" patas.");

            mesa.Patas.ForEach(Pata =>
            {
                Console.WriteLine(Pata.Color);
            });

            foreach (Pata pata in mesa.Patas)
            {
                Console.WriteLine(pata.Color);
            }

            

        }
    }
}