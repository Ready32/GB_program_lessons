// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.Write("Введите число, сумму цифр которого необходимо посчитать = ");
string num = Console.ReadLine();
char[] array = num.ToCharArray();
string[] str = new string[array.Length];

int[] Numbers = new int[array.Length];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    str[i] = Convert.ToString(array[i]);
    Numbers[i] = int.Parse(str[i]);
    result = result + Numbers[i];

}
System.Console.WriteLine("Сумма цифр числа " + num + " = " + result);