namespace Extructuras
{
    internal class Program
    {
         public struct persona
         {
            public string nombre;
            public string apellido;
            public string tipoDocumento;
            public int numeroDocumento;
            public DateTime fechaNacimiento;
            public string sexo;
            public string telefono;
            public string domicilo;
         }


        static void Main(string[] args)
        {
            //declaracion
            persona unaPersona;

            //asigancion de datos
            unaPersona.nombre = "juan";
            unaPersona.apellido = "Perez";
            unaPersona.numeroDocumento = 506324121;
            unaPersona.domicilo = "";

            //mostrar datos
            Console.WriteLine($"Nombre{unaPersona.nombre}");
            Console.WriteLine($"Apellido{unaPersona.apellido}");
            Console.WriteLine($"Numero Documento{unaPersona.numeroDocumento}");
            Console.WriteLine($"Domicilo{unaPersona.domicilo}");

            //declaracion de arreglos de tipo de persona
            persona[] personas = new persona[3];


            //asigancion de valores
            personas[0].apellido = "Rodriguez";
            personas[2].nombre = "Alberto";
            personas[2].numeroDocumento = 506324121;

            //mostrar datos
            Console.WriteLine($"Nombre: {personas[2].nombre}");
            Console.WriteLine($"Apellido: {personas[0].apellido}");
            Console.WriteLine($"Numero Documento: {personas[2].numeroDocumento}");
            //Console.WriteLine($"Domicilo: {personas[3].domicilo}");



        }
    }
}