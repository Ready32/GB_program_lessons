/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

System.Console.Write("Введите число до которого нужно вывести натуральные числа = ");
int n = Int32.Parse(Console.ReadLine());
System.Console.Write("Введите число от которого нужно вывести натуральные числа = ");
int m = Int32.Parse(Console.ReadLine());

int min = 0;
int max = 0;

if (n < m)
{
    min = n;
    max = m;
}
else
{
    min = m;
    max = n;
}

void Rec(int min, int max)
{

    if (min > max)
        return;

    Rec(min, max - 1);
    System.Console.Write($"{max} ");
}


System.Console.WriteLine($"Вывод чисел от {min} до {max}");
Rec(min, max);