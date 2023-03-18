namespace ejerciocio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //suma
            /* int resultado = 0;
             int numero1 = 0;
             int numero2 = 0;


             Console.WriteLine("Ingrese el primer numero...");
             numero1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Ingrese el segundo numero...");
             numero2 = Convert.ToInt32(Console.ReadLine());

             resultado = numero1 + numero2;
             Console.WriteLine($"La suma de {numero1} + {numero2} es {resultado}");
            */

            /*  Console.WriteLine("Mini Calcucadora");

              Console.WriteLine();
              Console.WriteLine("1: sumar");
              Console.WriteLine("2: restar");
              Console.WriteLine("3: multiplicar");
              Console.WriteLine("4: dividir");

              int opcion;
              do {
                  Console.WriteLine("Seleccione la operacion");
                  opcion = int.Parse(Console.ReadLine());
              }
              while ( opcion < 1 || opcion > 4);





              if ( (opcion >= 1) && (opcion <= 4))
              {



                  double num1, num2, resultado;

                  Console.WriteLine("Ingrese primer numero");
                  num1 = int.Parse(Console.ReadLine());

                  Console.WriteLine("Ingrese segundo numero");
                  num2 = int.Parse(Console.ReadLine());

                  switch (opcion)
                  {
                      case 1:
                          resultado = num1 + num2;
                          Console.WriteLine($"La suma de {num1} + {num2} es {resultado}");
                          break;
                      case 2:
                          resultado = num1 - num2;
                          Console.WriteLine($"La resta de {num1} - {num2} es {resultado}");
                          break;
                      case 3:
                          resultado = num1 * num2;
                          Console.WriteLine($"La multiplicacion de {num1} * {num2} es {resultado}");
                          break;
                      case 4:
                          resultado = num1 / num2;
                          Console.WriteLine($"La divicion de {num1} / {num2} es {resultado}");
                          break;


                  }

              } else
              {
                  Console.WriteLine("La opcion ingresada no es valida");
              }*/

            // Piramide

            int cantidad = 10;

            for (int i = 1; i <= cantidad; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine();
                }
                Console.Write("*");
            }


        }
    }
}