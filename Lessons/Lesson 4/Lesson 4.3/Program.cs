// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


System.Console.Write("Какой длины массив необходимо вывести? - ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a];

for (int i = 0; i < a; i++)
{
    System.Console.Write("Введите [" + i + "] элемент массива = ");
    array[i] = int.Parse(Console.ReadLine());
}
string s = String.Join(", ", array);
System.Console.Write("Ваш массив - " + "[" + s + "]");