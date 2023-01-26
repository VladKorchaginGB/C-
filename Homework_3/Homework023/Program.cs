// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void TablCube(double N)
{
    Console.Write(N + " -> ");
    for (int i = 2; i < N + 1; i++)
    {
        double result = Math.Pow(i, 3);
        Console.Write(result + ",");
    }
}
Console.WriteLine("Введите число");
string numString = Console.ReadLine();
int num = Convert.ToInt32(numString);
TablCube(num);