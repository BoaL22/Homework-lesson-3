/*
    Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("введите число");
int N = Convert.ToInt32(Console.ReadLine());
int CurrentNumber = 1;
int B = 0;


while (CurrentNumber <= N)
{
    B = CurrentNumber * CurrentNumber * CurrentNumber; 
    //number * number;
    Console.Write($"{B}, ");
    CurrentNumber++;
}
Console.WriteLine();
