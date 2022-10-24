// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите число А, которое надо возвести в степень = ");
int A = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число B, которое будет являться степенью числа А = ");
int B = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 1; i <= B; i++)
{
    result = result * A;
}

System.Console.WriteLine(result);