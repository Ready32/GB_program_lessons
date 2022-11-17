/* Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент. */

/* MEX
1. Ищем минимальное число в массиве
2. Ищем есть ли (минимальное число + 1)
3. Если нет, то MEX = (минимальное число + 1)
Иначе перезаписываем минимальное число и повторяем алгоритм */


int[] array = new int[5] { 0, 0, 0, 1, 5 };
int mex = 0;

Array.Sort(array);

if (array[0] == 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == mex + 1)
        {
            mex = array[i];
        }
    }
    mex = mex + 1;

}
else if (array[0] < 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == mex - 1)
        {
            mex = array[i];
        }
    }

}
else
{
    mex = array[0] - 1;
}

System.Console.WriteLine("MEX = " + (mex));