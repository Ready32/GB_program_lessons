/* Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент. */

/* MEX
1. Ищем минимальное число в массиве
2. Ищем есть ли (минимальное число + 1)
3. Если нет, то MEX = (минимальное число + 1)
Иначе перезаписываем минимальное число и повторяем алгоритм */

/* 0   8
3   6
2   1
4   4
2   4
3   2
0   3 */


int[] array = new int[4] { 5, 2, 3, 1 };
int mex = array[0];
int result;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < mex)
    {
        mex = array[i];

    }
}

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == mex + 1)
    {
        mex = mex + 1;
    }


}
System.Console.WriteLine("MEX = " + (mex + 1));