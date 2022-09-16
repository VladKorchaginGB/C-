Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{arr[i]}| ");

    }
    return arr;
}
int[] array = GetArray(12, -9, 9);
int positiveSum = 0;
int negativeSum = 0;
foreach (int el in array)
{
    if (el > 0) positiveSum += el;
    else negativeSum += el;
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {positiveSum}, Сумма отрицательных чисел = {negativeSum}");