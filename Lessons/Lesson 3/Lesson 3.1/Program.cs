// Задача 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

System.Console.Write("Введите число для проверки на палиндромность = ");
string number = Console.ReadLine();
char[] CharNumber = number.ToCharArray();
Array.Reverse(CharNumber);
string NewNumber = new string(CharNumber);

if (number == NewNumber)
{
    System.Console.WriteLine("Данная запись является палиндромом");
}
if (number != NewNumber)
{
    System.Console.WriteLine("Данная запись не является палиндромом");
}