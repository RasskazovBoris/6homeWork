// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество цифр: ");
int numberOfDigits = int.Parse(Console.ReadLine());

int acc = 0;
int number;
for (int i = 0; i < numberOfDigits; i++)
{
    Console.Write($"Введите число № {i + 1}: ");
    number = int.Parse(Console.ReadLine());
    acc = number > 0 ? acc + 1 : acc + 0;

}
Console.WriteLine($"Количество введенных пользователем чисел больше нуля - {acc}!");