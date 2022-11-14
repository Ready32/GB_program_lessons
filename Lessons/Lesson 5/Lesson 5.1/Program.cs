//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2


Console.Write("Введите размерность массива = ");
int[] arr = new int[int.Parse(Console.ReadLine())];
int result = 0;
for (int i = 0; i < arr.Length; i++)
{
    Random rand = new Random();
    int num = rand.Next(100, 999);
    int resultNum = num;
    arr[i] = resultNum;

    if (arr[i] % 2 == 0)
    {
        result++;
    }
}

string s = String.Join(", ", arr);
System.Console.Write("Ваш массив - " + "[" + s + "]");
System.Console.WriteLine();
System.Console.WriteLine("Всего чётных элементов в массиве - " + result);