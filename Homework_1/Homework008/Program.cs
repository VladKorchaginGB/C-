//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
string N_string = Console.ReadLine();
int N = Convert.ToInt32(N_string);
if (N % 2 == 0)
{
    while (N >= 1)
    {
        Console.WriteLine(N);
        N = N - 2;
    }
}
else
{
    N = N - 1;
    while (N >= 1)
    {
        Console.WriteLine(N);
        N = N - 2;
    }
}