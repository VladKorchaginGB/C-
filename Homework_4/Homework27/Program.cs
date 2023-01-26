// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Console.WriteLine("Введите число");
// string numString = Console.ReadLine();
// int numbers = Convert.ToInt32(numString);


// void SumNumbers(int num)
// {
//     int lenghtNum = num;
//     int count = 0;
//     while (lenghtNum > 0)
//     {
//         lenghtNum /= 10;
//         count += 1;
//     }
//     int[] arrayNumbers = new int[count];
//     for (int i = 0; i < arrayNumbers.Length; i++)
//     {
//         arrayNumbers[i] = num % 10;
//         num /= 10;
//     }
//     count = 0;
//     for (int i = 0; i < arrayNumbers.Length; i++)
//     {
//         count += arrayNumbers[i];
//     }
//     Console.WriteLine(count);

// }
// SumNumbers(numbers);
// Очень сложное, длинное и неоптимальное решение

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


