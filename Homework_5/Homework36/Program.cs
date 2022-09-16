// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{arr[i]} |");
    }
    Console.WriteLine();
    return arr;
}
int SumNumbersIndex(int[] arr)
{
    int sum = 0;
    int length = arr.Length;
    for (int i = 1; i < length; i = i + 2)
    {
        sum += arr[i];
    }
    return sum;
}
int[] array = GetArray(6, -20, 20);
int result = SumNumbersIndex(array);
Console.WriteLine($"Сумма элементов стоящих на начетных позициях = {result}");
