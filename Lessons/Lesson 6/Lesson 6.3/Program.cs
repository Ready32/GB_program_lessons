﻿/* Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент. */

/* MEX
1. Сортируем массив по возрастанию
2. Проверяем равняется ли нулевой элемент массива нулю?
    2.1 Если да, то проверяем является ли следующий элемент больше предыдущего на 1?
    2.2 Если да, то записываем в mex этот элемент массива
    2.3 Иначе Mex = mex + 1;
3. Проверяем меньше ли нулевой элемент массива чем ноль?
    3.1 Если да, то перебираем массив и ищем ноль.
    3.2 Если ноль есть, то записываем в mex = array[i];
    3.3 Возращаемся к пункту 2.1
4. Иначе в случае когда нулевой элемент массива не равень и не больше нуля - записываем mex = array[0]-1, тем самым находим минимальный отсутствующий элемент;
 */


int[] array = new int[5] { 1, 3, 4, 5, 6 };
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
        if (array[i] == 0)
        {
            mex = array[i];
            for (int n = 0; n < array.Length; n++)
            {
                if (array[n] == mex + 1)
                {
                    mex = array[n];
                }
            }
            mex = mex + 1;
        }
    }

}
else
{
    mex = array[0] - 1;
}

System.Console.WriteLine("MEX = " + (mex));