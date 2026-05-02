int productos, dias, fila;

Console.WriteLine("Ingrese los productos: ");

while(!int.TryParse(Console.ReadLine(), out productos) || productos <= 0)
{
    Console.WriteLine("Error, intente otra vez...");
}

Console.WriteLine("Ingrese los Días: ");

while (!int.TryParse(Console.ReadLine(), out dias)  || dias <= 0)
{
    Console.WriteLine("Error...");
}

int[,] ventas = new int[productos,dias];

for (int i = 0; i <  productos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.WriteLine($"Venta [{i},{j}]: ");
        while (!int.TryParse(Console.ReadLine(), out ventas[i, j]))
        {
            Console.WriteLine("Error.. vuelva intentar");
        }
    }
}


Console.WriteLine("Producto a ver: ");
while(!int.TryParse (Console.ReadLine(), out fila) || fila <0 || fila > productos)
{
    Console.WriteLine("Fila invalida: ");
}

for (int j=0; j<productos; j++)
{
    Console.Write();
}