// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
void WeekDay(int day)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Этот день считается выходным");
    }
    else
    {
        Console.WriteLine("Этот день считается рабочим");
    }
}
Console.WriteLine("Введите число от 1 до 7");
string numString = Console.ReadLine();
int num = Convert.ToInt32(numString);
WeekDay(num);