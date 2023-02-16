// Задача 44:выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5
// --> 0 1 1 2 3
// Если N = 3
// --> 0 1 1
// Если N = 7
// --> 0 1 1 2 3 5 8

Console.Write("Введите количество чисел Фибоначчи: ");
int numberOfDigits = int.Parse(Console.ReadLine());

if (numberOfDigits <= 0) Console.WriteLine("Введите число больше 0!");
else if (numberOfDigits == 1) Console.WriteLine("0");
else if (numberOfDigits == 2) Console.WriteLine("0, 1");
else
{
    Console.Write ("0, 1");
    int number1 = 0;
    int number2 = 1;
    int number3;
    for (int i = 2; i < numberOfDigits; i++)
    {
        number3 = number1 + number2;
        number1 = number2;
        number2 = number3;
        
        Console.Write ($", {number3}");
    }
    
}