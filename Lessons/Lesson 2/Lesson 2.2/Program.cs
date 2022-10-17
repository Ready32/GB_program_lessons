// Задача 13 //

System.Console.Write("Введите число, 3-ю цифру которого необходимо вывести = ");
string s = Console.ReadLine();
char[] str = s.ToCharArray();
Array.Reverse(str);
int a = int.Parse(str);
System.Console.Write("Задача №13 - ");
if (a > 99)
{
    Console.WriteLine((a / 100) % 10);
}
else
{
    System.Console.WriteLine("Третье цифры нет");
}