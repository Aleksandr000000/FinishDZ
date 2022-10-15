// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


double GetNumberFromConsole()
{
    Console.Write("Введите N: ");
    return Convert.ToDouble(Console.ReadLine());
}

void WriteNumbersRecursionVoid(double startNumber, int lastNumber)
{
    if (lastNumber <= startNumber)
    {
        Console.Write(startNumber + " ");
        WriteNumbersRecursionVoid(startNumber - 1, lastNumber);
    }
}

/// ОСНОВНАЯ ПРОГРАММА
double number = GetNumberFromConsole();
Console.Write($"N = {number} -> ");
WriteNumbersRecursionVoid(Math.Round(number), 1);
