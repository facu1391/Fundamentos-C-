// See https://aka.ms/new-console-template for more information

string nombre = "Juan Perez";
string Domicilio,
domicilio = "Av Santa Fe 1000";

char opcion = 'S';

// tipos de datos enteros
byte edad = 26;

int altura = 1000;

double importe = 798.35;

bool estaActivo = true; // false
bool esMayor = edad >= 21;


tipoTurno turno = tipoTurno.Noche;
tipoTurno turno1 = tipoTurno.Tarde;

Meses mesActual = Meses.Enero;

double? promedio = null;

int? otraEdad = null;

DateTime fecha = new DateTime(); // ---> 01/01/0001
DateTime fechaNacimiento = new DateTime(2022, 07, 20);
DateTime fechaHoy = DateTime.Now;
DateTime horaActual = DateTime.Now;

Console.WriteLine("Fehca Nac.:" + fechaNacimiento.ToString("dd/MM/yyyy"));
Console.WriteLine("Fehca Actual.:" + fechaNacimiento.ToString("dd/MM/yyyy"));
Console.WriteLine("Fehca Hora Acutal.:" + fechaNacimiento.ToString("HH:mm"));
Console.WriteLine(fechaHoy - horaActual);


Console.WriteLine("Uso de Variables!");
Console.WriteLine("El nombre es: " + nombre);
Console.WriteLine("Mi noimbre es {1} y el mes actual es: {0}", mesActual, nombre);



enum tipoTurno
{
    Mañana,
    Tarde,
    Noche
}

enum Meses
{
    Enero = 0,
    Febrero = 1,
    Marzo = 2,
    Abril = 3
}

