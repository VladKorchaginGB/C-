//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
void ThruePalindrome(int num)
{
    if (num > 9999 && num < 100000)
    {
        int firstPart = num % 100;
        int secondPart = num / 1000;
        if (firstPart - secondPart == -9 || firstPart - secondPart == 9)
        {
            Console.WriteLine("Это палиндром!");
        }
        else
        {
            Console.WriteLine("Это не палиндром!");
        }
    }
    else
    {
        Console.WriteLine("Надо было ввести пятизначное число!");
    }
}
Console.WriteLine("Введите число");
string numString = Console.ReadLine();
int num = Convert.ToInt32(numString);
ThruePalindrome(num);




