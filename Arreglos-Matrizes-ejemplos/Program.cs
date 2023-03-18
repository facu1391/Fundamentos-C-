namespace Arreglos_Matrizes_ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de Arreglo");

            int cantidad = 0;

            //solicitar la cantidad de datos a ingresar
            Console.WriteLine("Ingrese la cantidad de datos");
            cantidad = int.Parse(Console.ReadLine());

            int[][][] datos;

            int[] notas = new int[cantidad];
            int nota;
            //permite ingresar las notas
            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"Ingrese el dato {i}:");
                nota = int.Parse(Console.ReadLine());
                notas[i] = nota;
            }

            //mostra los datos del arreglo Notas
            for(int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Nota[{i}], nota asignada {notas[i]}");
            }

            //calcular el promedio
            double sumatoria = 0;
            double promedio = 0; 
            for (int i = 0; i < notas.Length; i++)
            {
                //sumatoria = sumatoria + notas[i];
                sumatoria += notas[i];
            }
            promedio = sumatoria / cantidad;

            Console.WriteLine($"El promedio es {promedio}");
        }
    }
}