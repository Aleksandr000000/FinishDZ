// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumberFromConsole(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void NumberSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    NumberSum(m, n, sum);
}

/// ОСНОВНАЯ ПРОГРАММА
int sum = 0;
int m = GetNumberFromConsole("Введите значение M: ");
int n = GetNumberFromConsole("Введите значение N: ");
NumberSum(m, n, sum);