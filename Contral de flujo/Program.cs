namespace Contral_de_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               IF (condicion)
                   Sentencia;

               Sentencias2 

               IF (condicion) {
                   Sentencia1;
                   Sentencia2;
                   Sentencia3;
               }
             */


 /*            const int Mayor_Edad = 21;
             int edad = 10;

             Console.WriteLine("Ingrese la edad:");
             edad = int.Parse(Console.ReadLine());

             if (edad >= Mayor_Edad)
             {
                 Console.WriteLine("Es mayor de edad");
             }
             else
             {
                 Console.WriteLine("Es menor de edad");
 */
                #region "tabla"
                /* operdador && "And" "Y"
                    
                   val1   val2   val3  
                   false  false  false
                   true   false  false
                   false  true   false
                   true   true   true
                 
                */
                /* operdador || "or" "o"

                 val1   val2   val3  
                 false  false  false
                 true   false  true
                 false  true   true
                 true   true   true

              */
                /* operdador ! "negacion" !valor

                val1   val2   
                true   false  
                false  true 
                

             */


                #endregion



 /*               Console.WriteLine("Ingrese una opcion (A o B o 0");
            string opcion = Console.ReadLine();

                opcion = opcion.ToUpper().Trim();
                if (!(opcion == "A" || opcion == "B" || opcion == "0"))
                { 
                    if (opcion == "A")
                        Console.WriteLine("opcion selecciona 'A'");
                    else if (opcion == "B")
                        Console.WriteLine("opcion selecciona 'B'");
                    else if (opcion == "0")
                        Console.WriteLine("opcion selecionada '0");
                    else
                        Console.WriteLine("la opcion ingresada no es valida");
               }
 */
                #region "ejemplo de switch"
                Console.WriteLine("Ingrese una opcion (A o B o 0");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                
                    case "A": Console.WriteLine("opcion ingresada 'A'");
                        break;
                    case "B": Console.WriteLine("opcion ingresada 'B");
                        break;
                    case "0": Console.WriteLine("opcion ingresada '0");
                        break;
                    default:
                        Console.WriteLine("la opcion ingresada no es valida");
                        break;
                }

                #endregion
            }
        }
      


    }
}