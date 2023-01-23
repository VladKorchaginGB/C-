// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
void ThirdDigit(int num)
{
    int result = 0;
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while (num >= 100)
        {
            result = num % 10;
            num /= 10;
        }
        Console.WriteLine(result);
    }
}
Console.WriteLine("Введите трехзначное число");
string numString = Console.ReadLine();
int num = Convert.ToInt32(numString);
ThirdDigit(num);