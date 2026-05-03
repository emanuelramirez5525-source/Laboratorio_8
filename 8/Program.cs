int jugadores, niveles;

Console.Write("Jugadores: ");

while (!int.TryParse(Console.ReadLine(), out jugadores) || jugadores <=0)
{
    Console.Write("Error: ");
}

Console.Write("Nivel: ");
while (!int.TryParse(Console.ReadLine(), out niveles) || niveles <= 0)
{
    Console.Write("Error: ");
}

int[,] puntajes = new int[jugadores, niveles];

for (int i = 0; i<jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        Console.Write($"Puntaje [{i} , {j}]");
        while(!int.TryParse(Console.ReadLine(), out puntajes[i,j]))
        {
            Console.Write("Error");
        }
    }
}

int mayor = puntajes[0, 0];

for (int i = 0; i < jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        if (puntajes[i,j] > mayor)
        {
            mayor = puntajes[i, j];
        }
    }
}

Console.WriteLine("Puntaje mayor: " + mayor);