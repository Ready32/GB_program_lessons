// Задача 10 //

System.Console.Write("Задача №10 - ");
int a = 782;
int LastNum = a % 100;
int MiddleNum = LastNum / 10;
System.Console.WriteLine(MiddleNum);

// Задача 13 //

System.Console.Write("Задача №13 - ");
int b = 32769;
if (b / 100 == 0)
{
    System.Console.WriteLine("Третье цифры нет");
}
else
{
    int LastNumB = b % 10;
    System.Console.WriteLine(LastNumB);
}


// Задача 15//
System.Console.Write("Задача №15 - ");
int c = 3;
if (c <= 5)
{
    System.Console.WriteLine("Будний день");
}
else
{
    System.Console.WriteLine("Выходной");
}

// Задача 9 //
System.Console.Write("Для проверки кратности числам 7 и 23 введите число = ");
int n = int.Parse(Console.ReadLine());
int num1 = 7, num2 = 23;
System.Console.Write("Задача №9 - ");
if (n % 7 == 0)
{
    if (n % 23 == 0)
    {
        System.Console.WriteLine("Число " + n + " - кратно числам 7 и 23 одновременно.");
    }
    else
    {
        System.Console.WriteLine("Число " + n + " - не кратно числам 7 и 23 одновременно.");
    }
}
else
{
    System.Console.WriteLine("Число " + n + " - не кратно числам 7 и 23 одновременно.");
}
