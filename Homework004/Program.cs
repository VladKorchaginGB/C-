//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
int a = 22;
int b = 3;
int c = 9;
int max = 0;
if (a > b)
{
    if (a > c)
    {
        max = a;
    }
    else
    {
        max = c;
    }
}
else
{
    if (b > c)
    {
        max = b;
    }
    else
    {
        max = c;
    }
}
Console.Write("max = ");
Console.WriteLine(max);
//Проверенно с тремя разными вариациями!