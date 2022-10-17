// Задача 9 //
System.Console.Write("Для проверки кратности числам 7 и 23 введите число = ");
int n = int.Parse(Console.ReadLine());
int num1 = 7, num2 = 23;
System.Console.Write("Задача №9 - ");
if (n % 7 == 0 && n % 23 == 0)
{
    System.Console.WriteLine("Число " + n + " - кратно числам 7 и 23 одновременно.");
}
else
{
    System.Console.WriteLine("Число " + n + " - не кратно числам 7 и 23 одновременно.");
}

