// Una empresa de monitoreo ambiental necesita registrar las temperaturas de diferentes zonas durante varios días.
//Solicite al usuario la cantidad de zonas (filas) y la cantidad de días (columnas). 
//Luego, permita ingresar las temperaturas registradas y muestre la información en forma de tabla organizada.

Console.WriteLine("MONITOREO AMBIENTAL TEMPERATURAS ");
Console.WriteLine("Ingrese la cantidad de zonas (filas)");
int zonas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de días (columnas)");
int dias = int.Parse(Console.ReadLine());

int[,] matriz = new int[zonas, dias];

Console.WriteLine("Matriz");

for (int i = 0; i < zonas; i++)
{
  for (int j = 0; i < dias; j++) 
    {
        Console.WriteLine($"Ingrese la temperatura de la zona {}");
    }
}

