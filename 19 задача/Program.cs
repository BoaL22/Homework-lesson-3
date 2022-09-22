/*
    Задача 19
    Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

    14212 -> нет
    12821 -> да
    23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
string A = Convert.ToString(number);

if (A.Length == 5)
{
    if (A[0] == A[4]&& A[1] == A[3])
    {
        Console.WriteLine($"{number} является палиндромом");
    }

    else
    {
        Console.WriteLine($"{number} НЕ является палиндромом");
    }
}

    else //( A.Length < 5 || A.Length > 5 ) 
{
    Console.WriteLine($"{number} НЕ пятизначное число");
}
