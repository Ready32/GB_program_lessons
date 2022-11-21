/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] array1 = new int[2, 2] { { 2, 4 }, { 3, 2 } };
int[,] array2 = new int[2, 2] { { 3, 4 }, { 3, 3 } };

if (array1.GetLength(1) == array2.GetLength(0))
{

    PrintArray(multiplierArray(array1, array2));
}
else if (array2.GetLength(1) == array1.GetLength(0))
{
    System.Console.WriteLine("Матрицу АхБ нелья умножить...");
    System.Console.WriteLine("Но можно умножить наоборот БхА");
    PrintArray(multiplierArray(array1, array2));
}
else
{
    System.Console.WriteLine("Матрицы нельзя умножить...");
}


int[,] multiplierArray(int[,] array1, int[,] array2)

{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
                resultArray[i, j] += array1[i, k] * array2[k, j];
        }
    }
    return resultArray;
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
