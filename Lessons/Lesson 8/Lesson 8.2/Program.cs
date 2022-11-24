/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
 */

System.Console.Write("Введите количество строк массива = ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива = ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[a, b];
array = GetArrayRandom(a, b);
System.Console.WriteLine("Ваш массив");
PrintArray(array);
int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}
System.Console.WriteLine("Строка № " + indexLine + " имеет наименьшую сумму элементов");
System.Console.WriteLine("Сумма элементов в строке = " + minsum);


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




/* int[,] array = new int[4, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
PrintArray(array);

int sum1 = 0;
int sum2 = 0;
int sum3 = 0;
int sum4 = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    sum1 = sum1 + array[0, i];
    sum2 = sum2 + array[1, i];
    sum3 = sum3 + array[2, i];
    sum4 = sum4 + array[3, i];

}
System.Console.WriteLine("Суммы строк = {0} {1} {2} {3}", sum1, sum2, sum3, sum4 + " соответсвенно.");

PrintСomparison(sum1, sum2, sum3, sum4);

void PrintСomparison(int sum1, int sum2, int sum3, int sum4)
{
    if (sum1 < sum2 && sum1 < sum3 && sum1 < sum4)
    {
        System.Console.WriteLine("Строка 1 имеет наименьшую сумму элементов");
    }
    else if (sum2 < sum3 && sum2 < sum4)
    {
        System.Console.WriteLine("Строка 2 имеет наименьшую сумму элементов");
    }
    else if (sum3 < sum4)
    {
        System.Console.WriteLine("Строка 3 имеет наименьшую сумму элементов");
    }
    else
    {
        System.Console.WriteLine("Строка 4 имеет наименьшую сумму элементов");
    }
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
} */