// Задача 2 //

System.Console.Write("Задача №2 - ");
int a = 5, b = 7;
if (a > b)
{
    System.Console.WriteLine("Наибольшее число А = " + a);
}
else
{
    System.Console.WriteLine("Наибольшее число B = " + b);
}

// Задача 4 //

System.Console.Write("Задача №4 - ");
int c = 44, d = 5, e = 78;
if (c > d)
{
    if (c > e)
    {
        System.Console.WriteLine("Наибольшее число C = " + c);
    }
    else
    {
        System.Console.WriteLine("Наибольшее число E = " + e);
    }
}
else
{
    if (d > e)
    {
        System.Console.WriteLine("Наибольшее число D = " + d);
    }
    System.Console.WriteLine("Наибольшее число E = " + e);
}


// Задача 6 //

System.Console.Write("Задача №6 - ");
int f = -3;
if (f % 2 == 0)
{
    System.Console.WriteLine("Число " + f + " - четное");
}
else
{
    System.Console.WriteLine("Число " + f + " - не четное");
}

// Задача 8 //
System.Console.WriteLine("Введите число N, в котором нужно найти все четные числа...");

int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Всё четные числа входяище в число N - ");
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }

}
