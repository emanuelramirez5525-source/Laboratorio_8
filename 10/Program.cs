int sucursales, productos, fila;

Console.Write("Sucursales: ");
while(!int.TryParse (Console.ReadLine(), out sucursales) || sucursales <=0)
{
    Console.Write("Error");
}

Console.Write("Productos: ");
while (!int.TryParse(Console.ReadLine(), out productos) || productos <= 0)
{
    Console.Write("Error");
}

int[,] inventario = new int[sucursales, productos];

for (int i = 0; i <sucursales; i++)
{
    for (int j = 0; j < productos; i++)
    {
        Console.Write($"Cantidad [{i}, {j}]");
        while (!int.TryParse (Console.ReadLine(),out inventario[i, j]))
        {
            Console.Write("Error: ");
        }
    }
}

Console.Write("Sucursal a ver: ");
while (!int.TryParse(Console.ReadLine(), out fila) || fila <= 0)
{
    Console.Write("Error");
}

for (int j = 0; j < productos; j++)
{
    Console.Write(inventario[fila,j]+ " ");
}    