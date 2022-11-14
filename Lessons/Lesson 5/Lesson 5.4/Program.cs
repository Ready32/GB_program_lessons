/* Дополнительно. Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. При отсутствии числа возвращать -1.
 */

//Создаём рандомный массив


System.Console.Write("Введите число ОТ которого будем строить массив = ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число ДО которого будем строить массив = ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите размерность массива = ");
int[] arr = new int[Convert.ToInt32(Console.ReadLine())];

for (int i = 0; i < arr.Length; i++)
{
    Random rand = new Random();
    double num = rand.Next(num1, num2);
    int resultNum = Convert.ToInt32(num);
    arr[i] = resultNum;
}
string s = String.Join(", ", arr);
System.Console.Write("Ваш массив - " + "[" + s + "]");
System.Console.WriteLine();

System.Console.Write("Введите число индекс которого необходимо вывести = ");
int x = Convert.ToInt32(Console.ReadLine());

int[] array = new int[arr.Length];
for (int i = 0; i < arr.Length; i++) // ищем индексы числа введеного пользователем
{
    if (arr[i] == x)
    {
        array[i] = i;
    }
    else if (array[i] != x) // если на данном индексе числа нет, то заполняем числом не входящим в массив в данном случае максимально возможный элемент + 1.
    {
        array[i] = num2 + 1;
    }
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] != num2 + 1)
    {
        System.Console.Write("Ваше число стоит на индексе - ");
        System.Console.WriteLine(array[i]);
    }
    else
    {
        int a = -1;
    }
}

// как то криво всё, чёт не допираю как что дальше))) Но на половину вроде бы работает.