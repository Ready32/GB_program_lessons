/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Write("Введите размерность массива = ");
int[] arr = new int[int.Parse(Console.ReadLine())];
int result = 0;
for (int i = 0; i < arr.Length; i++)
{
    Random rand = new Random();
    int num = rand.Next(1, 50);
    int resultNum = num;
    arr[i] = resultNum;

    if (i % 2 != 0)
    {
        result = result + arr[i];
    }
}

string s = String.Join(", ", arr);
System.Console.Write("Ваш массив - " + "[" + s + "]");
System.Console.WriteLine();
System.Console.WriteLine("Сумма элеметнот стоящих на нечетных позициях = " + result);



