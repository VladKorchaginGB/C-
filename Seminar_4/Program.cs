Console.Clear();
Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
int SumNum(int number)
{
    int sum_result = 0;
    for (int i = number; i > 0; i--)
    {
        sum_result = sum_result + i;
    }
    return sum_result;
}
Console.WriteLine($"Сумма чисел = {SumNum(num)}");