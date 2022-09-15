// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
Console.Clear();
int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int result = 1;
for (int i = B; i > 0; i--)
{
    result = result * A;
}
Console.WriteLine(result);
