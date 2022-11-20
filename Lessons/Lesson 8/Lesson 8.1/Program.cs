/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] array = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
PrintArray(array);
int[] row1 = new int[4];
int[] row2 = new int[4];
int[] row3 = new int[4];
for (int i = 0; i < array.GetLength(1); i++)
{
    row1[i] = array[0, i];
    row2[i] = array[1, i];
    row3[i] = array[2, i];

}
Array.Sort(row1);
Array.Reverse(row1);
Array.Sort(row2);
Array.Reverse(row2);
Array.Sort(row3);
Array.Reverse(row3);

Console.WriteLine("---------------------------");
Console.WriteLine("Сортировка по строкам: ");
PrintArray(ArraySort(row1, row2, row3));

int[,] ArraySort(int[] row1, int[] row2, int[] row3)
{
    int[,] arraySort = new int[3, 4];

    for (int i = 0; i < row1.Length; i++)
    {
        arraySort[0, i] = row1[i];
        arraySort[1, i] = row2[i];
        arraySort[2, i] = row3[i];
    }
    return arraySort;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}