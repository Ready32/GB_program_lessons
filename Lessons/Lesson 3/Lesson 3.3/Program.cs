// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


System.Console.Write("Введите число до которого будет выполняться возведение в куб = ");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("{0}\t{1}", "число", "куб");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
}