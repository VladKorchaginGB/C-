//Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
string a1_string = Console.ReadLine();
int a1 = Convert.ToInt32(a1_string);
string b1_string = Console.ReadLine();
int b1 = Convert.ToInt32(b1_string);
int max1 = 0;
int min1 = 0;
if (a1 > b1)
{
    max1 = a1;
    min1 = b1;
}
else
{
    min1 = a1;
    max1 = b1;
}
Console.Write("max1 = ");
Console.WriteLine(max1);
Console.Write("min1 = ");
Console.WriteLine(min1);



