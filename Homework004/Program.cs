//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
string a_string = Console.ReadLine();
int a = Convert.ToInt32(a_string);
string b_string = Console.ReadLine();
int b = Convert.ToInt32(b_string);
string c_string = Console.ReadLine();
int c = Convert.ToInt32(c_string);
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