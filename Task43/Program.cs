// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, 
//y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите координату b1: ");
double b1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите координату k1: ");
double k1 = double.Parse(Console.ReadLine());
System.Console.Write("Введите координату b2: ");
double b2 = double.Parse(Console.ReadLine());
System.Console.Write("Введите координату k2: ");
double k2 = double.Parse(Console.ReadLine());


double x = (-b2 + b1) / (k2 - k1);
double y = (k2 * x) + b2;

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые имеют бесконечное количество точек пересечения!");
else if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны!");
else
    Console.WriteLine($"Точка пересечений двух прямых = ({x};{y})");