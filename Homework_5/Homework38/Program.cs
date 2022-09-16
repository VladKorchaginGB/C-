//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
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
void DifferenceMaxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    foreach (int el in arr)
    {
        if (el > max) max = el;
        else if (el < min) min = el;
    }
    int result = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {result}");
}
int[] array = GetArray(5, -10, 20);
DifferenceMaxMin(array);