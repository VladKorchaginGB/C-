// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


void quantity(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    Console.Write($"Количество чисел больше нуля = {count}");
}
Console.Write("Введите количество чисел, которые хотите ввести = ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Вводите числа, которые необходимо проверить");
int[] arrNumb = new int[M];
for (int i = 0; i < M; i++)
{
    arrNumb[i] = int.Parse(Console.ReadLine());
}
quantity(arrNumb);
