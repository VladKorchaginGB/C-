void Weekand(int day)
{
    int[] week = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
    if (day == week[5])
    {
        Console.WriteLine("ДА");
    }
    else if (day == week[6])
    {
        Console.WriteLine("ДА");
    }
    else
    {
        Console.WriteLine("НЕТ");
    }
}
Weekand(6);