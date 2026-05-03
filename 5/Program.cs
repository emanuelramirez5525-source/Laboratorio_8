
int f, c, buscar;
bool encontrado = false;

Console.Write("Filas: ");

while(!int.TryParse(Console.ReadLine(), out f ) || f <= 0)
{
    Console.Write("Error: ");
}

Console.Write("Columnas");

while (int.TryParse(Console.ReadLine(),out c) || c <= 0)
{
    Console.WriteLine("Error: ");
}

int[,] mat = new int[f, c];

for (int i = 0; i < f; i++)
{
    for (int j=0; j<c; j++)
    {
        Console.Write($"Valor [{i},{j}]");
        while (!int.TryParse(Console.ReadLine(), out mat[i, j]))
        {
            Console.Write("Error:");
        }
    }
}

Console.Write("Buscar: ");
while (!int.TryParse(Console.ReadLine(),out buscar))
{
    Console.Write("Error: ");
}

for (int i = 0; i < f; i++)
{
    for (int j =0; j < c; j++)
    {
        if (mat[i,j] == buscar)
        {
            Console.WriteLine($"Encontrado en [{i}, {j}]");
        }
    }
}
if (!encontrado)
{
    Console.WriteLine("No existe");
}
