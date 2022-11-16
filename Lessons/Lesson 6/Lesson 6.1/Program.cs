/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

System.Console.Write("Сколько чисел будем вводить? - ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
int result = 0;

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write("Введите число №" + (i + 1) + " - ");
    double num = double.Parse(Console.ReadLine());
    array[i] = Convert.ToInt32(num);

}


for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        result = result + 1;
    }
}

System.Console.WriteLine("В вашем наборе " + result + " - элемент(a)(ов) больше 0");