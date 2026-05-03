int filas, columnas, buscar;
bool encontrado = false;

Console.Write("Filas: ");
while (!int.TryParse(Console.ReadLine(), out filas ) || filas <=0)
{
    Console.Write("Error: ");

}

Console.Write("Columnas: ");
while (!int.TryParse(Console.ReadLine(), out columnas) || columnas <= 0)
{
    Console.Write("Error: ");

}

int[,] errores = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Error: [{i},{j}]");
        while(!int.TryParse(Console.ReadLine(), out errores[i, j]))
        {
            Console.Write("Error");
        }
    }
}

Console.Write("Codigo a buscar: ");

while (!int.TryParse(Console.ReadLine(), out buscar))
{
    Console.Write("Error:");
}

for (int i =0; i<filas; i++)
{
    for (int j =0; j < columnas; j++)
    {
        if (errores[i,j] == buscar)
        {
            Console.WriteLine($"Encontrado en [{i},{j}]");
            encontrado = true;
        }
    }
}

if (!encontrado)
{
    Console.WriteLine("No existe");
}