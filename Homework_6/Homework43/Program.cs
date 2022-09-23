//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, 
//y = k2 * x + b2; 
//значения k1, b1, k2 и b2 задаются пользователем.

double[,] matrixNumbers = new double[2, 2];

for (int row = 0; row < matrixNumbers.GetLength(0); row++)
{
    for (int column = 0; column < matrixNumbers.GetLength(1); column++)
    {
        matrixNumbers[row, column] = double.Parse(Console.ReadLine());
    }
}
void IntersectionPoint(double[,] matrix)
{
    double y;
    double x;
    x = (matrix[0, 0] - matrix[1, 0]) / (matrix[1, 1] - matrix[0, 1]);
    y = matrix[1, 1] * x + matrix[1, 0];
    Console.WriteLine($"{x}, {y}");

}
IntersectionPoint(matrixNumbers);
