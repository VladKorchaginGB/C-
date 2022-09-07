string number_string = Console.ReadLine();
int number = Convert.ToInt32(number_string);
if (number > 5)
{
    if (number < 10)
    {
        Console.WriteLine("Соответствующая надпись");
    }
    else
    {
        Console.WriteLine("Неизвестное число");
    }
}
else
{
    Console.WriteLine("Неизвестное число");
}