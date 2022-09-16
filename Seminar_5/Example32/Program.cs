// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]}|");
    }
    return array;

}
int[] arr = GetArray(10, -50, 50);
Console.WriteLine();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;
    Console.Write($"{arr[i]} |");
}
