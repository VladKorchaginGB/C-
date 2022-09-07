// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void TablCube(double N)
{
    for (int i = 1; i < N + 1; i++)
    {
        double result = Math.Pow(i, 3);
        Console.WriteLine(result);
    }
}
TablCube(4);