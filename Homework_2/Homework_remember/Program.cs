//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа. 
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите трехзначное число");
string numString = Console.ReadLine();
int num = Convert.ToInt32(numString);

int secondDigit(int num)
{
    if (num / 100 >= 1)
    {
        int result = num % 100;
        result = result / 10;
        return result;
    }
    else
    {
        return 0;
    }

}
Console.WriteLine(secondDigit(num));