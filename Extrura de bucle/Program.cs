namespace Extrura_de_bucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine("bucle for");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"el valor de i es {i}");
            }
           
        }
    }
}