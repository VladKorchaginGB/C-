// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10, 11);
    Console.Write($"{array[i]} |");
}
Console.WriteLine();
void CheckNumber(int number, int[] arr)
{
    int a = 0;
    foreach (int el in arr)
    {
        if (el == number) a += 1;
    }
    if (a > 0) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
CheckNumber(45, array);