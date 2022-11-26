/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

System.Console.Write("Введите число от которого будем считать сумму = ");
int n = Int32.Parse(Console.ReadLine());
System.Console.Write("Введите число до которого будем считать сумму = ");
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

int[] array = new int[max];

void Rec(int min, int max, int sum = 0)
{

    if (min > max)
    {
        System.Console.Write($"{sum} ");
        return;
    }
    else
    {
        sum = sum + max;
        Rec(min, max - 1, sum);
    }
}

Rec(min, max);
System.Console.Write($" - Сумма элементов от {min} до {max}");
