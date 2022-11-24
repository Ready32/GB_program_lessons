/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */


Console.Write("Введите количество строк массива = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива = ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];
array = GetArrayRandom(a, b);
Console.WriteLine("Рандомный массив = ");
PrintArray(array);

int temp = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
            if (array[i, k] < array[i, k + 1])
            {

                temp = array[i, k];
                array[i, k] = array[i, k + 1];
                array[i, k + 1] = temp;
            }
    }
}
System.Console.WriteLine("Сортированный массив = ");
PrintArray(array);


int[,] GetArrayRandom(int a, int b, int minValue = 0, int maxValue = 20)
{
    int[,] array = new int[a, b];
    int count = a * b;

    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(minValue, maxValue);
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
