/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

System.Console.Write("Введите размерность массива nxn = ");

int size = Convert.ToInt32(Console.ReadLine());


PrintArray(GetSpiralArray(size));

int[,] GetSpiralArray(int size)
{
    int num = 1;
    int i = 0;
    int j = 0;
    int[,] array = new int[size, size];
    while (num <= Math.Pow(size, 2))
    {
        array[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
            ++j;
        else if (i < j && i + j >= size - 1)
            ++i;
        else if (i >= j && i + j > size - 1)
            --j;
        else
            --i;
        ++num;
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                Console.Write(array[i, j] + " ");
            }
        }
        System.Console.WriteLine();
    }
}

