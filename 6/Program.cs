Console.WriteLine("ASISTENCIA DE ESTUDIANTES");

int estudiante, dias, fila;

Console.Write("estudiantes: ");

while (!int.TryParse(Console.ReadLine(), out estudiante) || estudiante <= 0)
{
    Console.Write("Error: ");
}

while (!int.TryParse(Console.ReadLine(), out dias) || dias <= 0)
{
    Console.Write("Error: ");
}

int[,]  asistencia = new int[estudiante, dias];

for (int i = 0; i < estudiante; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Asistencia  [{i}, {j} (1 o 0): ");
        while(!int.TryParse(Console.ReadLine(),out asistencia[i,j]) || (asistencia[i, j] != 0 && asistencia[i, j] != 1))
            {
            Console.Write("Error: ");
            }
    }
}

Console.Write("Estudiante a mostrar: ");
while (!int.TryParse(Console.ReadLine(), out fila) || fila<0 || fila >=estudiante)
{
    Console.Write("Error: ");
}

for (int j = 0; j <= dias; j++)
{
    Console.Write(asistencia[fila, j] + "");
}