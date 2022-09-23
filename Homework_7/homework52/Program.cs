//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] matrix = new int[5, 5];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        matrix[row, column] = new Random().Next(0, 10);
    }
}
for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.Write($"|{matrix[row, column]}|");
    }
    Console.WriteLine();
}
void ArithmeticMean(int[,] matrix)
{
    double[] arr = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            arr[j] += matrix[i, j];
        }
    }
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        arr[i] = arr[i] / matrix.GetLength(0);
    }

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.WriteLine($"среднее арифмитеческое = {arr[i]}");
    }
}
ArithmeticMean(matrix);