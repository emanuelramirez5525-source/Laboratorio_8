int aptos, dias, suma = 0;

Console.Write("Apartamentos: ");
while(!int.TryParse(Console.ReadLine(), out aptos) || aptos <=0)
{
    Console.Write("Error: ");
}

Console.Write("Dias: ");
while (!int.TryParse(Console.ReadLine(),out dias) || dias <=0)
{
    Console.Write("Error: ");
}

int[,] consumo = new int[aptos, dias];

for (int i = 0; i < aptos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Consumo [{i}, {j}]");
        while (!int.TryParse(Console.ReadLine(), out consumo[i, j]))
            {
            Console.Write("Error:  ");
            }
        suma += consumo[i, j];
    }    
}

Console.WriteLine("Total: + " + suma);