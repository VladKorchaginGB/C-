// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
Console.Write("Введите число ");
int numbers = int.Parse(Console.ReadLine());

void SumFigures(int num)
{
    int sumResult = 0;
    while (num > 0)
    {
        sumResult = sumResult + num % 10;
        num = num / 10;
    }
    Console.WriteLine(sumResult);
}
SumFigures(numbers);


