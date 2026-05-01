

Console.WriteLine("Solicitar número de productos");
int productos = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el número de días");
int dias = int.Parse(Console.ReadLine());

int[,] matriz = new int[productos, dias];

for (int i = 0; i < productos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.WriteLine(matriz);
    }
}