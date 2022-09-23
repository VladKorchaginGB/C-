//Задача 47. Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами.m = 3, n = 4.
int m = 3;
int n = 4;
double[,] matrixNumbers = new double[m, n];

for (int row = 0; row < matrixNumbers.GetLength(0); row++)
{
    for (int column = 0; column < matrixNumbers.GetLength(1); column++)
    {
        matrixNumbers[row, column] = new Random().NextDouble() * 20;
    }
}
for (int row = 0; row < matrixNumbers.GetLength(0); row++)
{
    for (int column = 0; column < matrixNumbers.GetLength(1); column++)
    {
        Console.Write($"|{matrixNumbers[row, column]}|");
    }
    Console.WriteLine();
}