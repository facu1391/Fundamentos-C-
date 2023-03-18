namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arreglos, Matrices");

            float[] temperaturas = new float[10];
            //asignacion  /decaracion de arreglo vacio
            temperaturas[1] = 10.3f;
            temperaturas[1] = 15.5f;
            temperaturas[2] = 201f;
            temperaturas[3] = 23f;
            temperaturas[4] = 5f;

            //declaracion / asignacion
            double[] notas = { 9, 50, 10, 7.5, 2 };
            //mostrar elementos de arreglos
            for (int i = 0; i < temperaturas.Length; i++)
            {
                //   if (i == 3) break;
                if (i == 0) continue;
                Console.WriteLine($"Temperaturas [{i}] valor {temperaturas[i]}");
            }

            int indice = 0;
            while (indice < notas.Length )
            {
                Console.WriteLine($"Notas [{indice}] valor {notas[indice]}");
                indice++;
            }

        }
    }
}