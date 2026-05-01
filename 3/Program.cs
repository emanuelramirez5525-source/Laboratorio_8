// See https://aka.ms/new-console-template for more information

Console.WriteLine("CONSUMO ELÉCTRICO TOTAL");
Console.WriteLine("Ingrese el números de departamos");
int departamento = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el número de días");
int dias = int.Parse(Console.ReadLine());

int[,] matriz = new int [departamento, dias];

