int productos, dias, fila;

Console.WriteLine("Ingrese los productos: ");

while(!int.TryParse(Console.ReadLine(), out productos) || productos <= 0)
{
    Console.Write("Error, intente otra vez...");
}

Console.Write("Ingrese los Días: ");

while (!int.TryParse(Console.ReadLine(), out dias)  || dias <= 0)
{
    Console.Write("Error...");
}

int[,] ventas = new int[productos,dias];

for (int i = 0; i <  productos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Venta [{i},{j}]: ");
        while (!int.TryParse(Console.ReadLine(), out ventas[i, j]))
        {
            Console.Write("Error.. vuelva intentar");
        }
    }
}


Console.WriteLine("Producto a ver: ");
while(!int.TryParse (Console.ReadLine(), out fila) || fila <0 || fila > productos)
{
    Console.Write("Fila invalida: ");
}

for (int j=0; j<productos; j++)
{
    Console.Write(ventas[fila,j] + "");
}