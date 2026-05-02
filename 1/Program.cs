


Console.Write("Ingrese Zonas: ");
int zonas;
while(!int.TryParse(Console.ReadLine(), out zonas) || zonas <= 0)
{
    Console.Write("Ingrese un número valido");
}

    Console.Write("Ingrese Días: ");
     int dias;
while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0)
{
    Console.Write("Ingrese un número valido");
}

double[,] temp = new double[zonas, dias];

for (int i = 0; i < zonas; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Ingrese Temperatura [{i},{j}]: ");
        while(!double.TryParse(Console.ReadLine(), out temp[i,j]))
        {
            Console.Write("Error, valor incorrecto, ingrese denuevo");
        }
      
    }
}

Console.WriteLine("\nTabla:");

for (int i = 0; i < zonas; i++)
{
    for (int j = 0;j < dias; j++)
    {
        Console.Write(temp[i,j] +  "\t");
    }
    Console.WriteLine();
}    