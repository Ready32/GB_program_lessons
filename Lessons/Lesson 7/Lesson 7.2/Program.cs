/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет */

System.Console.Write("Введите количество строк массива = ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество колонок массива = ");
int b = int.Parse(Console.ReadLine());

int[,] array = GetArrayRandom(a, b);
PrintArray(array);

System.Console.Write("Введите строку элемента массива - ");
int row = int.Parse(Console.ReadLine());
while (row > a)
{
    System.Console.WriteLine("Такой строки нет...");
    System.Console.Write("Попробуйте ещё раз - ");
    row = int.Parse(Console.ReadLine());
}
System.Console.Write("Введите столбец элемента массива - ");
int column = int.Parse(Console.ReadLine());
if (column > b)
{
    System.Console.WriteLine("Такой колонки нет...");
    System.Console.Write("Попробуйте ещё раз - ");
    column = int.Parse(Console.ReadLine());
}

System.Console.WriteLine("Ваш элемент = " + array[row - 1, column - 1]);

int[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[rows, cols];

    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");

        }
        System.Console.WriteLine();
    }
}

