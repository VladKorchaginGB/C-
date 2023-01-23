//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
string N_string = Console.ReadLine();
int N = Convert.ToInt32(N_string);
int all = 0;
if (N % 2 == 0)
{
    N -= 2;
    while (N > all)
    {
        all += 2;
        Console.WriteLine(all);
    }
}
else
{
    N = N - 1;
    while (N > all)
    {
        all += 2;
        Console.WriteLine(all);
    }
}