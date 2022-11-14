// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11

System.Console.Write("Введите число N, что бы вывести таблицу простых чисел от 1 до N = ");
int n = int.Parse(Console.ReadLine()!);
int x = 2;
int i = 2;

while (n > x)
{
    while (i < n)
    {
        for (int a = 2; a < n; a++)
        {
            if (n % a == 0)
            {
                System.Console.WriteLine(n + " - не простое");
                n--;
            }
            else
            {
                System.Console.WriteLine(n + " - простое");
                n--;
            }
        }


        i++;
    }
    n--;
    System.Console.WriteLine(i);

}