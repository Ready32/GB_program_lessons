/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

double k1, k2, b1, b2;
System.Console.Write("Введите переменные k1 для уравнения y=k1x+b1 - ");
k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите переменные b1 для уравнения y=k1x+b1 - ");
b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите переменные k2 для уравнения y=k2x+b2 - ");
k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите переменные b2 для уравнения y=k2x+b2 - ");
b2 = Convert.ToDouble(Console.ReadLine());

if (k1 - k2 != 0)
{
    double x = (b1 - b2) / -(k1 - k2);
    if (k1 * x + b1 == k2 * x + b2)
    {
        System.Console.WriteLine("Прямые пересекаются в точке - " + "(" + x + " ; " + (k1 * x + b1) + ")");
    }
    else
    {
        System.Console.WriteLine("Прямые не пересекаются...");
    }
}
else
{
    System.Console.WriteLine("Error");
}



