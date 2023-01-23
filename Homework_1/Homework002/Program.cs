//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
string firstString = Console.ReadLine();
int first = Convert.ToInt32(firstString);
Console.WriteLine("Введите второе число: ");
string secondString = Console.ReadLine();
int second = Convert.ToInt32(secondString);
int max = 0;
int min = 0;
if (first > second)
{
    max = first;
    min = second;
}
else
{
    min = first;
    max = second;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);



