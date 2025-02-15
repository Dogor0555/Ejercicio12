using System;

Console.Write("Ingrese la calificación del estudiantee (entre 0 y 100): ");
int calificacion = int.Parse(Console.ReadLine());

switch (calificacion)
{
    case int n when (n >= 90 && n <= 100):
        Console.WriteLine("Calificación: A");
        break;
    case int n when (n >= 80 && n < 90):
        Console.WriteLine("Calificación: B");
        break;
    case int n when (n >= 70 && n < 80):
        Console.WriteLine("Calificación: C");
        break;
    case int n when (n >= 60 && n < 70):
        Console.WriteLine("Calificación: D");
        break;
    case int n when (n < 60 && n >= 0):
        Console.WriteLine("Calificación: F");
        break;
    default:
        Console.WriteLine("Calificación inválida. Ingrese un valor entre 0 y 100.");
        break;
}
