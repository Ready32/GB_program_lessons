/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

// Размерность массива
int a = 3;
int b = 3;
int c = 3;

int[,,] array = new int[a, b, c];

PrintArray(GetArrayRandom(a, b, c));

// Заполнение массива рандомными значениями
int[,,] GetArrayRandom(int a, int b, int c, int minValue = 10, int maxValue = 50)
{
    int[,,] array = new int[a, b, c];
    int count = a * b * c;
    int[] RandomNumber = new int[count];

    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int check = rnd.Next(minValue, maxValue);
                    if (GetArrayUnique(array, check) == false)
                    {
                        array[i, j, k] = check;
                    }
                }
            }
        }
    }
    return array;
}

// Проперка на повторяющиеся элементы в массиве
bool GetArrayUnique(int[,,] array, int check)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == check)
                    return true;
            }
        }
    }
    return false;
}

// Выводим наш массив
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write("[" + i + "," + j + "," + k + "]" + array[i, j, k] + " ");

            }
        }
        System.Console.WriteLine();
    }
}