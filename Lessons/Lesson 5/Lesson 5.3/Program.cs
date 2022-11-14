/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

System.Console.Write("Введите число ОТ которого будем строить массив = ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число ДО которого будем строить массив = ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размерность массива = ");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

for (int i = 0; i < arr.Length; i++)
{
    Random rand = new Random();
    double num = rand.Next(num1, num2);
    int resultNum = Convert.ToInt32(num);
    arr[i] = resultNum;
}
string s = String.Join(", ", arr);
System.Console.Write("Ваш массив - " + "[" + s + "]");

int min = arr[0];
int max = arr[arr.Length - 1];

for (int i = 0; i < arr.Length; i++)
{
    if (min > arr[i])
    {
        min = arr[i];
    }
    else if (max < arr[i])
    {
        max = arr[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine("Максимальное число массива = " + max);
System.Console.WriteLine("Минимальное число массива = " + min);
System.Console.WriteLine("Сумма максимального и минимального значения массива = " + Math.Abs(Math.Abs(max) - Math.Abs(min)));

