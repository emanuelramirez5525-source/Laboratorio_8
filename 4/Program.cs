
Console.WriteLine("CALIFICACIÓNES");

int estudiantes, evaluaciones;

Console.Write("Estudiante: ");
 
while (!int.TryParse(Console.ReadLine(), out estudiantes  ))
{
    Console.Write("Error: ");
}

Console.Write("Evaluaciónes: ");

while (!int.TryParse(Console.ReadLine(), out evaluaciones ))
{
    Console.Write("Error: ");
}

int[,] notas = new int[estudiantes, evaluaciones];

for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < evaluaciones; j++)
    {
        Console.Write($"Nota [{i},{j}]");
        while( !int.TryParse(Console.ReadLine(), out notas[i,j]))
        {
            Console.Write("Error: ");
        }
    }
}

int mayor = notas[0,0];

for (int i = 0;i < estudiantes; i++)
{
    for (int j = 0; j < evaluaciones; j++)
    {
        if (notas[i, j] > mayor)
        {
            mayor = notas[i, j];    
        }
    }
}
Console.WriteLine("Mayor: " + mayor);