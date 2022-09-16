// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
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
void EvenNumbers(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) count += 1;
    }
    Console.WriteLine($"Колличество четных чисел в массиве = {count}");
}
int[] array = GetArray(10, 100, 999);
EvenNumbers(array);