//Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
int SecondNumber(int num)
{
    num = num / 10;
    num = num % 10;
    return num;
}
int test = SecondNumber(486);
Console.WriteLine(test);
