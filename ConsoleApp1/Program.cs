int maquinas, turnos, total = 0;

Console.Write("Maquinas: ");
while (!int.TryParse(Console.ReadLine(), out maquinas) || maquinas <= 0)
{
    Console.Write("Error:");
}

Console.Write("Turnos: ");

while (!int.TryParse(Console.ReadLine(), out turnos) || turnos <= 0)
{
    Console.Write("Error:");
}

int[,] produccion = new int[maquinas, turnos];

for (int i = 0; i <maquinas; i++)
{
    for (int j = 0; j < turnos; j++)
    {
        Console.Write($"Producción [{i},{j}]");
        while (!int.TryParse(Console.ReadLine(),out produccion[i, j]))
        {
            Console.Write("Error");
        }

        total += produccion[i, j];
    }
}

Console.WriteLine("Producción total: " + total);