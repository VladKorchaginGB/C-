//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] matrix = new int[5, 5];

for (int row = 0; row < matrix.GetLength(0); row++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        matrix[row, column] = new Random().Next(-10, 10);
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
void ItemValues(int row, int column, int[,] matrix)
{
    if (row > 0 && row < matrix.GetLength(0) && column > 0 && column < matrix.GetLength(1))
    {
        Console.WriteLine($"на позиции {row},{column} находится элемент {matrix[row, column]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }

}
Console.WriteLine("Введите позицию элемента");
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
ItemValues(rows, columns, matrix);